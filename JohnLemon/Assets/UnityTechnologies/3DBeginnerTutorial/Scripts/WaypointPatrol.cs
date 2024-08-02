using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] wayplints;

    int m_CurrentWaypointIndex;

    void Start()
    {
        navMeshAgent.SetDestination(wayplints[0].position);
    }

    void Update()
    {
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % wayplints.Length;
            navMeshAgent.SetDestination(wayplints[m_CurrentWaypointIndex].position);
        }
    }
}
