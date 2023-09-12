using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropencondition : MonoBehaviour
{
    bool i = false;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        i = FindObjectOfType<dooropencondition>().i;

        if (i == true)
        {

            animator.SetTrigger("opendoor");

        }
        
    }
}
