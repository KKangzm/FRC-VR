using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjUIName : MonoBehaviour
{
    private GameObject mCamera;
    public Text txtName;

    void Start()
    {
        mCamera = GameObject.FindGameObjectWithTag("MainCamera");
        transform.forward = new Vector3(1, 0, 0);
    }

    void Update() 
    {
        transform.forward = new Vector3(transform.position.x, transform.position.y, transform.position.z)
        - new Vector3(mCamera.transform.position.x, mCamera.transform .position.y, mCamera.transform .position.z);
	}

    public void SetTextName(string strName)
    {
        txtName.text = strName;
    }
}
