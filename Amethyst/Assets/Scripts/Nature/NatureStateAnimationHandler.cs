using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NatureStateAnimationHandler : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent agent;

    private NatureAI wolf;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        wolf = GetComponent<NatureAI>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        NatureAIState aiState = wolf.aiState;

        switch(aiState)
        {
            case NatureAIState.Walk:
                anim.SetInteger("states", 0);
                agent.speed = 1;
                break;
            case NatureAIState.Dig:
                anim.SetInteger("states", 1);
                agent.speed = 0;
                break;
            case NatureAIState.Run:
                anim.SetInteger("states", 2);
                agent.speed = 2.5f;
                break;
        }
    }
}
