using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssembleManager : MonoBehaviour
{   
    [Header("材质")] 
    public Material material_default;
    public Material material_blue, material_red, material_green;

    [Header("装配顺序")]
    public GameObject obj_1;
    public GameObject obj_2, obj_3, obj_4, obj_5_1, obj_5_2, obj_6_1, obj_6_2, obj_6_3, obj_6_4, obj_7_1, obj_7_2, obj_8_1, obj_8_2, obj_9_1, obj_9_2, obj_10;
    public GameObject obj_11_1, obj_11_2, obj_12_1, obj_12_2, obj_13_1, obj_13_2, obj_14, obj_15_1, obj_15_2, obj_15_3;
    public GameObject obj_16_1, obj_16_2, obj_16_3, obj_16_4, obj_16_5, obj_16_6, obj_16_7, obj_16_8, obj_17_1, obj_17_2, obj_18_1, obj_18_2, obj_18_3;
    public GameObject obj_19, obj_20_1, obj_20_2, obj_20_3, obj_20_4, obj_21_1, obj_21_2, obj_22_1, obj_22_2, obj_22_3, obj_22_4, obj_23_1, obj_23_2;
    public GameObject obj_24, obj_25, obj_26, obj_27_1, obj_27_2, obj_28, obj_29_1, obj_29_2, obj_30;
    public GameObject obj_31_1, obj_31_2, obj_31_3, obj_31_4, obj_31_5, obj_31_6, obj_31_7, obj_31_8, obj_31_9, obj_31_10, obj_31_11, obj_31_12, obj_31_13;
    public GameObject obj_32, obj_33, obj_34, obj_35_1, obj_35_2, obj_36, obj_37, obj_38_1, obj_38_2, obj_38_3, obj_39_1, obj_39_2, obj_39_3, obj_39_4;
    public GameObject obj_40_1, obj_40_2;

    private int iNum;
    private int iMultiple = 0;

    void Start()
    {
        iNum = 1;
        obj_1.GetComponent<BoxCollider>().enabled = true;

        StartCoroutine(SetMaterial());
    }

    IEnumerator SetMaterial()
    {
        yield return new WaitForSeconds(2);

        obj_1.GetComponent<Trigger>().CanAssemble();
    }

    public void NextAssemble()
    {
        if(iMultiple == 0)
        {
            iNum += 1;
        }

        switch(iNum)
        {
            case 2:
                obj_2.GetComponent<BoxCollider>().enabled = true;
                obj_2.GetComponent<Trigger>().CanAssemble();
                break;
            case 3:
                obj_3.GetComponent<BoxCollider>().enabled = true;
                obj_3.GetComponent<Trigger>().CanAssemble();
                break;
            case 4:
                obj_4.GetComponent<BoxCollider>().enabled = true;
                obj_4.GetComponent<Trigger>().CanAssemble();
                break;
            case 5:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_5_1.GetComponent<BoxCollider>().enabled = true;
                    obj_5_2.GetComponent<BoxCollider>().enabled = true;

                    obj_5_1.GetComponent<Trigger>().CanAssemble();
                    obj_5_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 6:
                if(iMultiple == 0)
                {
                    iMultiple = 4;
                    obj_6_1.GetComponent<BoxCollider>().enabled = true;
                    obj_6_2.GetComponent<BoxCollider>().enabled = true;
                    obj_6_3.GetComponent<BoxCollider>().enabled = true;
                    obj_6_4.GetComponent<BoxCollider>().enabled = true;

                    obj_6_1.GetComponent<Trigger>().CanAssemble();
                    obj_6_2.GetComponent<Trigger>().CanAssemble();
                    obj_6_3.GetComponent<Trigger>().CanAssemble();
                    obj_6_4.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 7:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_7_1.GetComponent<BoxCollider>().enabled = true;
                    obj_7_2.GetComponent<BoxCollider>().enabled = true;

                    obj_7_1.GetComponent<Trigger>().CanAssemble();
                    obj_7_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 8:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_8_1.GetComponent<BoxCollider>().enabled = true;
                    obj_8_2.GetComponent<BoxCollider>().enabled = true;

                    obj_8_1.GetComponent<Trigger>().CanAssemble();
                    obj_8_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 9:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_9_1.GetComponent<BoxCollider>().enabled = true;
                    obj_9_2.GetComponent<BoxCollider>().enabled = true;

                    obj_9_1.GetComponent<Trigger>().CanAssemble();
                    obj_9_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 10:
                obj_10.GetComponent<BoxCollider>().enabled = true;
                obj_10.GetComponent<Trigger>().CanAssemble();
                break;
            case 11:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_11_1.GetComponent<BoxCollider>().enabled = true;
                    obj_11_2.GetComponent<BoxCollider>().enabled = true;

                    obj_11_1.GetComponent<Trigger>().CanAssemble();
                    obj_11_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 12:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_12_1.GetComponent<BoxCollider>().enabled = true;
                    obj_12_2.GetComponent<BoxCollider>().enabled = true;

                    obj_12_1.GetComponent<Trigger>().CanAssemble();
                    obj_12_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 13:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_13_1.GetComponent<BoxCollider>().enabled = true;
                    obj_13_2.GetComponent<BoxCollider>().enabled = true;

                    obj_13_1.GetComponent<Trigger>().CanAssemble();
                    obj_13_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 14:
                obj_14.GetComponent<BoxCollider>().enabled = true;
                obj_14.GetComponent<Trigger>().CanAssemble();
                break;
            case 15:
                if(iMultiple == 0)
                {
                    iMultiple = 3;
                    obj_15_1.GetComponent<BoxCollider>().enabled = true;
                    obj_15_2.GetComponent<BoxCollider>().enabled = true;
                    obj_15_3.GetComponent<BoxCollider>().enabled = true;

                    obj_15_1.GetComponent<Trigger>().CanAssemble();
                    obj_15_2.GetComponent<Trigger>().CanAssemble();
                    obj_15_3.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 16:
                if(iMultiple == 0)
                {
                    iMultiple = 8;
                    obj_16_1.GetComponent<BoxCollider>().enabled = true;
                    obj_16_2.GetComponent<BoxCollider>().enabled = true;
                    obj_16_3.GetComponent<BoxCollider>().enabled = true;
                    obj_16_4.GetComponent<BoxCollider>().enabled = true;
                    obj_16_5.GetComponent<BoxCollider>().enabled = true;
                    obj_16_6.GetComponent<BoxCollider>().enabled = true;
                    obj_16_7.GetComponent<BoxCollider>().enabled = true;
                    obj_16_8.GetComponent<BoxCollider>().enabled = true;

                    obj_16_1.GetComponent<Trigger>().CanAssemble();
                    obj_16_2.GetComponent<Trigger>().CanAssemble();
                    obj_16_3.GetComponent<Trigger>().CanAssemble();
                    obj_16_4.GetComponent<Trigger>().CanAssemble();
                    obj_16_5.GetComponent<Trigger>().CanAssemble();
                    obj_16_6.GetComponent<Trigger>().CanAssemble();
                    obj_16_7.GetComponent<Trigger>().CanAssemble();
                    obj_16_8.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 17:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_17_1.GetComponent<BoxCollider>().enabled = true;
                    obj_17_2.GetComponent<BoxCollider>().enabled = true;

                    obj_17_1.GetComponent<Trigger>().CanAssemble();
                    obj_17_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 18:
                if(iMultiple == 0)
                {
                    iMultiple = 3;
                    obj_18_1.GetComponent<BoxCollider>().enabled = true;
                    obj_18_2.GetComponent<BoxCollider>().enabled = true;
                    obj_18_3.GetComponent<BoxCollider>().enabled = true;

                    obj_18_1.GetComponent<Trigger>().CanAssemble();
                    obj_18_2.GetComponent<Trigger>().CanAssemble();
                    obj_18_3.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 19:
                obj_19.GetComponent<BoxCollider>().enabled = true;
                obj_19.GetComponent<Trigger>().CanAssemble();
                break;
            case 20:
                if(iMultiple == 0)
                {
                    iMultiple = 4;
                    obj_20_1.GetComponent<BoxCollider>().enabled = true;
                    obj_20_2.GetComponent<BoxCollider>().enabled = true;
                    obj_20_3.GetComponent<BoxCollider>().enabled = true;
                    obj_20_4.GetComponent<BoxCollider>().enabled = true;

                    obj_20_1.GetComponent<Trigger>().CanAssemble();
                    obj_20_2.GetComponent<Trigger>().CanAssemble();
                    obj_20_3.GetComponent<Trigger>().CanAssemble();
                    obj_20_4.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 21:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_21_1.GetComponent<BoxCollider>().enabled = true;
                    obj_21_2.GetComponent<BoxCollider>().enabled = true;

                    obj_21_1.GetComponent<Trigger>().CanAssemble();
                    obj_21_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 22:
                if(iMultiple == 0)
                {
                    iMultiple = 4;
                    obj_22_1.GetComponent<BoxCollider>().enabled = true;
                    obj_22_2.GetComponent<BoxCollider>().enabled = true;
                    obj_22_3.GetComponent<BoxCollider>().enabled = true;
                    obj_22_4.GetComponent<BoxCollider>().enabled = true;

                    obj_22_1.GetComponent<Trigger>().CanAssemble();
                    obj_22_2.GetComponent<Trigger>().CanAssemble();
                    obj_22_3.GetComponent<Trigger>().CanAssemble();
                    obj_22_4.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 23:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_23_1.GetComponent<BoxCollider>().enabled = true;
                    obj_23_2.GetComponent<BoxCollider>().enabled = true;

                    obj_23_1.GetComponent<Trigger>().CanAssemble();
                    obj_23_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 24:
                obj_24.GetComponent<BoxCollider>().enabled = true;
                obj_24.GetComponent<Trigger>().CanAssemble();
                break;
            case 25:
                obj_25.GetComponent<BoxCollider>().enabled = true;
                obj_25.GetComponent<Trigger>().CanAssemble();
                break;
            case 26:
                obj_26.GetComponent<BoxCollider>().enabled = true;
                obj_26.GetComponent<Trigger>().CanAssemble();
                break;
            case 27:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_27_1.GetComponent<BoxCollider>().enabled = true;
                    obj_27_2.GetComponent<BoxCollider>().enabled = true;

                    obj_27_1.GetComponent<Trigger>().CanAssemble();
                    obj_27_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 28:
                obj_28.GetComponent<BoxCollider>().enabled = true;
                obj_28.GetComponent<Trigger>().CanAssemble();
                break;
            case 29:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_29_1.GetComponent<BoxCollider>().enabled = true;
                    obj_29_2.GetComponent<BoxCollider>().enabled = true;

                    obj_29_1.GetComponent<Trigger>().CanAssemble();
                    obj_29_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 30:
                obj_30.GetComponent<BoxCollider>().enabled = true;
                obj_30.GetComponent<Trigger>().CanAssemble();
                break;
            case 31:
                if(iMultiple == 0)
                {
                    iMultiple = 13;
                    obj_31_1.GetComponent<BoxCollider>().enabled = true;
                    obj_31_2.GetComponent<BoxCollider>().enabled = true;
                    obj_31_3.GetComponent<BoxCollider>().enabled = true;
                    obj_31_4.GetComponent<BoxCollider>().enabled = true;
                    obj_31_5.GetComponent<BoxCollider>().enabled = true;
                    obj_31_6.GetComponent<BoxCollider>().enabled = true;
                    obj_31_7.GetComponent<BoxCollider>().enabled = true;
                    obj_31_8.GetComponent<BoxCollider>().enabled = true;
                    obj_31_9.GetComponent<BoxCollider>().enabled = true;
                    obj_31_10.GetComponent<BoxCollider>().enabled = true;
                    obj_31_11.GetComponent<BoxCollider>().enabled = true;
                    obj_31_12.GetComponent<BoxCollider>().enabled = true;
                    obj_31_13.GetComponent<BoxCollider>().enabled = true;

                    obj_31_1.GetComponent<Trigger>().CanAssemble();
                    obj_31_2.GetComponent<Trigger>().CanAssemble();
                    obj_31_3.GetComponent<Trigger>().CanAssemble();
                    obj_31_4.GetComponent<Trigger>().CanAssemble();
                    obj_31_5.GetComponent<Trigger>().CanAssemble();
                    obj_31_6.GetComponent<Trigger>().CanAssemble();
                    obj_31_7.GetComponent<Trigger>().CanAssemble();
                    obj_31_8.GetComponent<Trigger>().CanAssemble();
                    obj_31_9.GetComponent<Trigger>().CanAssemble();
                    obj_31_10.GetComponent<Trigger>().CanAssemble();
                    obj_31_11.GetComponent<Trigger>().CanAssemble();
                    obj_31_12.GetComponent<Trigger>().CanAssemble();
                    obj_31_13.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 32:
                obj_32.GetComponent<BoxCollider>().enabled = true;
                obj_32.GetComponent<Trigger>().CanAssemble();
                break;
            case 33:
                obj_33.GetComponent<BoxCollider>().enabled = true;
                obj_33.GetComponent<Trigger>().CanAssemble();
                break;
            case 34:
                obj_34.GetComponent<BoxCollider>().enabled = true;
                obj_34.GetComponent<Trigger>().CanAssemble();
                break;
            case 35:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_35_1.GetComponent<BoxCollider>().enabled = true;
                    obj_35_2.GetComponent<BoxCollider>().enabled = true;

                    obj_35_1.GetComponent<Trigger>().CanAssemble();
                    obj_35_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 36:
                obj_36.GetComponent<BoxCollider>().enabled = true;
                obj_36.GetComponent<Trigger>().CanAssemble();
                break;
            case 37:
                obj_37.GetComponent<BoxCollider>().enabled = true;
                obj_37.GetComponent<Trigger>().CanAssemble();
                break;
            case 38:
                if(iMultiple == 0)
                {
                    iMultiple = 3;
                    obj_38_1.GetComponent<BoxCollider>().enabled = true;
                    obj_38_2.GetComponent<BoxCollider>().enabled = true;
                    obj_38_3.GetComponent<BoxCollider>().enabled = true;

                    obj_38_1.GetComponent<Trigger>().CanAssemble();
                    obj_38_2.GetComponent<Trigger>().CanAssemble();
                    obj_38_3.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 39:
                if(iMultiple == 0)
                {
                    iMultiple = 4;
                    obj_39_1.GetComponent<BoxCollider>().enabled = true;
                    obj_39_2.GetComponent<BoxCollider>().enabled = true;
                    obj_39_3.GetComponent<BoxCollider>().enabled = true;
                    obj_39_4.GetComponent<BoxCollider>().enabled = true;

                    obj_39_1.GetComponent<Trigger>().CanAssemble();
                    obj_39_2.GetComponent<Trigger>().CanAssemble();
                    obj_39_3.GetComponent<Trigger>().CanAssemble();
                    obj_39_4.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
            case 40:
                if(iMultiple == 0)
                {
                    iMultiple = 2;
                    obj_40_1.GetComponent<BoxCollider>().enabled = true;
                    obj_40_2.GetComponent<BoxCollider>().enabled = true;

                    obj_40_1.GetComponent<Trigger>().CanAssemble();
                    obj_40_2.GetComponent<Trigger>().CanAssemble();
                }
                iMultiple -= 1;
                break;
        }
    }
}