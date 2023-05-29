using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalesSilverTape : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            try
            {
                other.GetComponent<Rigidbody>().isKinematic = true;
            }
            catch { }
        }
    }
}
