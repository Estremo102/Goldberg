using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionButton : MonoBehaviour
{
    [SerializeField]
    private Animator Fan;
    [SerializeField]
    GameObject TNT, Explosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Domino")
            try
            {
                other.GetComponent<ConstantForce>().enabled = false;
            }
            finally
            {
                Fan.SetBool("ButtonPressed", false);
                Explosion.SetActive(true);
                TNT.SetActive(false);
                Invoke("StopExplosion", 4f);
            }
    }

    private void StopExplosion() => Explosion.SetActive(false);
}
