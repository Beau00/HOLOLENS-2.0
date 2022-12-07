using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SimpleNPC : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] float decisionDelay = 3f;
    [SerializeField] Transform[] waypoints; int currentWaypoint = 0;
    public bool isWalking = false;

    enum EnemyStates
    {
        Patrolling
    }

    [SerializeField] EnemyStates currentState;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (currentState == EnemyStates.Patrolling)
        {
            agent.SetDestination(waypoints[currentWaypoint].position);
        }
    }

    void Update()
    {

        gameObject.transform.LookAt(waypoints[currentWaypoint]);

        if (currentState == EnemyStates.Patrolling)
        {
            if (Vector3.Distance(transform.position, waypoints[currentWaypoint].position) <= 0.2)
            {
                currentWaypoint++;
                if (currentWaypoint == waypoints.Length)
                {
                    currentWaypoint = 0;
                }
            }
            agent.SetDestination(waypoints[currentWaypoint].position);
        }
    }
}
