using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulkomat : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Material[] materials;
    private bool active = false;
    private int spawnedBalls = 0;

    [SerializeField] private GameObject[] floor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!active)
            {
                Invoke("Spawn", 4f);
                active = true;
            }
        }
    }

    private void Spawn()
    {
        if (spawnedBalls++ > 200)
        {
            foreach (var obj in floor)
            {
                obj.AddComponent<Rigidbody>();
                obj.layer = 12;
                obj.GetComponent<Rigidbody>().mass = 4;
            }
            return;
        }
        GameObject newBall = Instantiate(ball, spawnPoint);
        newBall.GetComponent<Renderer>().material = materials[Random.Range(0, materials.Length)];
        Invoke("Spawn", 0.1f);
    }
}
