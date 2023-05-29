using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    private Animator animator;
    [SerializeField] 
    private ConstantForce domino;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Domino")
            ActiveFan(other.gameObject);
    }

    private void ActiveFan(GameObject gameObject)
    {
        animator.SetBool("ButtonPressed", true);
        domino.enabled = true;
        gameObject.tag = "Player";
    }
}
