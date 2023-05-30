using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private GameObject go;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spr")
        {
            Invoke("C", 0.4f);
            Invoke("C2", 2f);
        }
    }

    private void C() =>
        rb.isKinematic = false;

    private void C2() =>
        go.SetActive(false);
}
