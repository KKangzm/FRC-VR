using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Animations;
using HighlightPlus;

public class Assemble : MonoBehaviour
{
    private Collider objCollider;
    private Rigidbody objRb;
    private ParentConstraint parentConstraint;
    private GameObject targetObj, objUI;
    private HighlightEffect objHigh;
    private AssembleManager assembleManager;
    private Hand handLeft, handRight;
    private bool isHit = false;
    private bool isOnce = true;
    private float animTime = 0.5f;

    [Header("装配顺序")]
    public int iAssemNum;
    public string strAssemName;

    void Start()
    {
        objCollider = transform.GetComponent<Collider>();
        objRb = transform.GetComponent<Rigidbody>();
        objHigh = GetComponent<HighlightEffect>();

        assembleManager = GameObject.Find("Assemble_Manager").GetComponent<AssembleManager>();
        handLeft = GameObject.Find("RobotHand_L").GetComponent<Hand>();
        handRight = GameObject.Find("RobotHand_R").GetComponent<Hand>();
    }

    //碰撞检测函数
    private void OnTriggerEnter(Collider other) 
    {
        if(other.GetComponent<Trigger>() != null)
        {
            targetObj = other.gameObject;
            if(other.GetComponent<Trigger>().iTriggerNum == iAssemNum)
            {
                isHit = true;
                //显示可以装配的材质
                targetObj.GetComponent<Trigger>().AssembleTrigger();
            }
            else
            {
                isHit = false;
                //显示不可装配的材质
                targetObj.GetComponent<Trigger>().CanNotAssemble();
            }
        }
    }
    //碰撞脱离检测函数
    private void OnTriggerExit(Collider other) 
    {
        if(other.GetComponent<Trigger>() != null)
        {
            targetObj = other.gameObject;
            isHit = false;
            //显示可以装配材质
            targetObj.GetComponent<Trigger>().CanAssemble();
        }
    }

    void Update()
    {
        if(isHit && !handLeft.isGrip && !handRight.isGrip && isOnce)
        {
            MoveToTarget();
            isOnce = false;
        }
    }

    //物体装配函数
    void MoveToTarget()
    {
        objRb.useGravity = false;
        objCollider.isTrigger = true;

        //装配动画
        transform.DOMove(targetObj.transform.position, animTime);

        StartCoroutine(ObjConstraintMove(animTime));
    }

    //装配体约束协程函数
    IEnumerator ObjConstraintMove(float fTime)
    {
        yield return new WaitForSeconds(fTime);

        ObjConstraint();
    }

    //物体约束函数
    private void ObjConstraint()
    {
        parentConstraint = gameObject.GetComponent<ParentConstraint>();

        //冻结轴向
        parentConstraint.translationAxis = Axis.X | Axis.Y | Axis.Z;
        parentConstraint.rotationAxis = Axis.X | Axis.Y | Axis.Z;

        //添加目标
        ConstraintSource constraintSource = new ConstraintSource() { sourceTransform = targetObj.transform, weight = 1};
        parentConstraint.SetSources( new List<ConstraintSource>() { constraintSource});

        //给物体添加相对偏移量
        parentConstraint.SetTranslationOffset(0, Vector3.zero);
        parentConstraint.SetRotationOffset(0, Vector3.zero);

        //激活组件
        parentConstraint.constraintActive = true;

        //关闭检测体与自己的碰撞器
        targetObj.GetComponent<BoxCollider>().enabled = false;
        targetObj.GetComponent<Trigger>().Normal();
        objCollider.enabled = false;

        //激活下一个装配检测体
        assembleManager.NextAssemble();

        //关闭物体高光
        objHigh.OnObjectHighlightEnd += EndHighlightObject;
    }

    bool EndHighlightObject(GameObject obj) {
        return true;
    }

    //开启高亮函数
    public void ShowHighlighter()
    {
        if(!handLeft.isGrip && !handRight.isGrip)
        {
            //开启零件高光
            objHigh.SetHighlighted(true);
            objHigh.SetGlowColor(new Color(0, 0.7f, 1, 0.5f));

            //同时UI显示零件名称
            ShowUIName(strAssemName);
        }
    }

    //关闭高亮函数
    public void CloseHighlighter()
    {
        //关闭零件高光
        objHigh.SetHighlighted(false);

        //摧毁UI名称
        Destroy(objUI);
    }

    //UI名称显示函数
    void ShowUIName(string strText)
    {
        objUI = GameObject.Instantiate(Resources.Load("ObjName")) as GameObject;
        ObjUIName objUIName = objUI.GetComponent<ObjUIName>();
        objUIName.SetTextName(strText);

        objUI.transform.position = transform.position + new Vector3(0, 0.2f, 0);
    }
}