using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Domino")
            ActiveFan();
    }

    private void ActiveFan() =>
        animator.SetBool("ButtonPressed", true);
}
