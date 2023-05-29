using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    [SerializeField]
    Rigidbody m_Rigidbody;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spr")
        {
            m_Rigidbody.isKinematic = false;
        }
    }
}
