using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSplit : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetTrigger("SplitTrigger");
        }
    }
}
