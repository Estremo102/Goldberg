using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissors : MonoBehaviour
{
    [SerializeField] private float TimeToStart;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        Invoke("Cut", TimeToStart);
    }

    private void Cut() => animator.SetBool("Start", true);
}
