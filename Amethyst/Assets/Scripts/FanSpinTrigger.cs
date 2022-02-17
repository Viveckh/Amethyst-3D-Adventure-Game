using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanSpinTrigger : MonoBehaviour
{
    public GameObject triggerGameObject;
    public GameObject fanGameObject;
    private Animator animator;

    private void Start()
    {
        animator = fanGameObject.GetComponent<Animator>();
        animator.speed = 0f;
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            animator.speed = 2f;
        }
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {
            animator.speed = 0f;
        }
    }
}
