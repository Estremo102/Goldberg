using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalesSilverTape : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objectsToFreeze;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            try
            {
                other.GetComponent<Rigidbody>().isKinematic = true;
            }
            finally
            {
                foreach(GameObject obj in objectsToFreeze)
                {
                    obj.AddComponent<FixedJoint>();
                }
            }
        }
    }
}
