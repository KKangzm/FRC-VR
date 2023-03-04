using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [Header("装配顺序")] public int iTriggerNum;
    MeshRenderer mesh;
    private AssembleManager assembleManager;

    void Start() 
    {
        assembleManager = GameObject.Find("Assemble_Manager").GetComponent<AssembleManager>();
        mesh = GetComponent<MeshRenderer>();

        Normal();
    }

    public void CanAssemble()
    {
        mesh.sharedMaterial = assembleManager.material_blue;
    }

    public void CanNotAssemble()
    {
        mesh.sharedMaterial = assembleManager.material_red;
    }

    public void Normal()
    {
        mesh.sharedMaterial = assembleManager.material_default;
    }

    public void AssembleTrigger()
    {
        mesh.sharedMaterial = assembleManager.material_green;
    }
}