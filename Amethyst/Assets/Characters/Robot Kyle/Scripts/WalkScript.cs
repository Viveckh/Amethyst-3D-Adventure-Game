using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkScript : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent agent;
    public float distance;

    private KyleKiller killer;
    public AIState aiState;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

        if (agent == null)
        {
            Debug.Log("No Nav Mesh Agent found");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        killer = GetComponent<KyleKiller>();
    }

    // Update is called once per frame
    void Update()
    {
        aiState = killer.aiState;
        distance = agent.remainingDistance;

        if (aiState == AIState.Attack){
           anim.SetBool("AtTarget", false);
           anim.SetBool("Attacking", true);
       }
       else if (aiState == AIState.Patrol || aiState == AIState.Persue){
           anim.SetBool("AtTarget", false);
           anim.SetBool("Attacking", false);
       }
        else if (aiState == AIState.Dead)
        {
            anim.SetBool("AtTarget", false);
            anim.SetBool("Attacking", false);
            anim.SetBool("Dead", true);
        }
    }
}
