using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoAutoMass : MonoBehaviour
{
    private void Awake()
    {
        float mass = GetComponent<Transform>().localScale.y;
        GetComponent<Rigidbody>().mass = mass * mass;
    }
}
