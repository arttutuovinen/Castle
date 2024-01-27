using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAnimator : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {

        if (Input.GetAxis("Vertical") > 0.0f)
        {
            animator.SetBool("IsMovingUp", true);
        }

        else if (Input.GetAxis("Vertical") < 0.0f)
        {
            animator.SetBool("IsMovingDown", true);
        }

        else
        {
            animator.SetBool("IsMovingUp", false);
            animator.SetBool("IsMovingDown", false);

        }
    }
}
