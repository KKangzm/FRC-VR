using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjRotate : MonoBehaviour
{
    public GameObject objRotate;

    public void SliderRotate(Slider slider)
    {
        if(objRotate != null)
        {
            float fAngle = 360 * slider.value;
            objRotate.transform.localEulerAngles = new Vector3(-90, fAngle, 0);
        }
    }
}
