using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionButton : MonoBehaviour
{
    [SerializeField]
    private Animator fan;
    private void OnTriggerEnter(Collider other)
    {
        try
        {
            other.GetComponent<ConstantForce>().enabled = false;
        }
        finally
        {
            fan.SetBool("ButtonPressed", false);
        }
    }
}
