using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    [SerializeField]
    Rigidbody m_Rigidbody;
    [SerializeField]
    GameObject m_GameObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spr")
        {
            Invoke("C", 0.4f);
            Invoke("C2", 2f);
        }
    }

    private void C() =>
        m_Rigidbody.isKinematic = false;

    private void C2() =>
        m_GameObject.SetActive(false);
}
