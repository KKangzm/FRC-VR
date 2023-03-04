using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    public float speed;
    public Material material1, material2;

    Animator animator;
    SkinnedMeshRenderer mesh;
    [HideInInspector] public bool isGrip = false;

    private float gripTarget;
    private float gripCurrent;
    private string animatorGripParam = "Grip";

    void Start()
    {
        animator = GetComponent<Animator>();
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();
        mesh.sharedMaterial = material1;
    }

    void Update()
    {
        AnimateHand();
    }

    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    void AnimateHand()
    {
        if(gripCurrent != gripTarget)
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            animator.SetFloat(animatorGripParam, gripCurrent);
        }
    }

    public void unVisibility()
    {
        mesh.sharedMaterial = material2;
        isGrip = true;
    }

    public void Visibility()
    {
        mesh.sharedMaterial = material1;
        isGrip = false;
    }
}
