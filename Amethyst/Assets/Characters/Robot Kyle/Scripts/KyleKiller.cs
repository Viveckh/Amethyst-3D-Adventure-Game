using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KyleKiller : MonoBehaviour
{
     private NavMeshAgent agent;

    public GameObject[] waypoints;
    public GameObject targetPoint;

    private int currentWaypoint;


    public static AIState aiState;
    private AIState previousState;

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
        currentWaypoint = -1;
        setNextWaypoint();

        // Set the AI state to Patroling to protect the gem.
        aiState = AIState.Patrol;
        previousState = AIState.Patrol;
    }

    // Update is called once per frame
    void Update()
    {
        confirmAIState();

        if (aiState == AIState.Patrol)
        {
            if (aiState != previousState)
            {
                resetToPatrol();
            }

            if (agent.remainingDistance <= agent.stoppingDistance && !agent.pathPending)
            {
                setNextWaypoint();
            }
        }

        if (aiState == AIState.Persue)
        {
            previousState = aiState;
            persueTarget();
        }

        if (aiState == AIState.Attack)
        {
            previousState = aiState;
            attack();
        }


        
    }

    void persueTarget()
    {
        agent.SetDestination(targetPoint.transform.position);
        FaceTarget();
    }

    void resetToPatrol()
    {
        previousState = aiState;
        setNextWaypoint();
    }

    void attack()
    {
        agent.SetDestination(targetPoint.transform.position);
        FaceTarget();
        // Debug.Log("Attacking...");
        
    }

    void confirmAIState()
    {
        float distance = Vector3.Distance(agent.transform.position, targetPoint.transform.position);

        //if (aiState == AIState.Persue && agent.remainingDistance <= agent.stoppingDistance && !agent.pathPending)
        //{
        //    aiState = AIState.Attack;
        //}
        if (distance > 1f && distance <= 10f ){
            aiState = AIState.Attack;
        }
        else if (distance < 20f)
        {
            aiState = AIState.Persue;
        }
        else
        {
            aiState = AIState.Patrol;
        }
    }

    private void setNextWaypoint()
    {
        if (waypoints.Length <= 0)
        {
            Debug.Log("Waypoints array is empty");
            return;
        }

        currentWaypoint++;

        if (currentWaypoint >= waypoints.Length)
        {
            currentWaypoint = 0;
        }

        agent.SetDestination(waypoints[currentWaypoint].transform.position);
        FaceTarget();
    }
    // public Transform target;
    // NavMeshAgent agent;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     agent=GetComponent<NavMeshAgent>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     agent.SetDestination(target.position);
    //     FaceTarget();
    // }

    void FaceTarget(){
        Vector3 direction = (targetPoint.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x,0,direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation,Time.deltaTime*5f);
    }
}
