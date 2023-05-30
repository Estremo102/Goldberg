using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mikolajoinator : MonoBehaviour
{
    [SerializeField] private GameObject mikolaj;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            mikolaj.SetActive(true);
    }
}
