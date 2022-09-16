using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public enum NatureAIState
{
    Walk = 0,
    Dig = 1,
    Run = 2
}

public class NatureAI : MonoBehaviour
{
    private NavMeshAgent agent;

    public GameObject[] waypoints;

    private int currentWaypoint;


    public NatureAIState aiState;
    private NatureAIState previousState;

    private float fiveSecondState = 0f;

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
        aiState = NatureAIState.Walk;
        previousState = NatureAIState.Walk;
    }

    // Update is called once per frame
    void Update()
    {
        changeState();

        if (aiState == NatureAIState.Walk)
        {
            if (agent.remainingDistance <= agent.stoppingDistance && !agent.pathPending)
            {
                setNextWaypoint();
            }
        }
    }

    private void changeState()
    {
        fiveSecondState += Time.deltaTime;

        if (fiveSecondState > 5f)
        {
            fiveSecondState = 0f;

            System.Random rand = new System.Random();

            int val = rand.Next(3);

            aiState = getState(val);
        }
    }

    private NatureAIState getState(int index)
    {
        switch(index)
        {
            case 0:
                return NatureAIState.Walk;
            case 1:
                return NatureAIState.Dig;
            case 2:
                return NatureAIState.Run;
            default:
                return NatureAIState.Walk;
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
    }
}
