using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tnt : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 10.0F;
    [SerializeField] private Rigidbody targetRigidbody;

    void Start()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
        }
        targetRigidbody.AddForce(new Vector3(15000f, 0f, 0f), ForceMode.Impulse);
    }
}