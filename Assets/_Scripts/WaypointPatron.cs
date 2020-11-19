using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class WaypointPatron : MonoBehaviour
{

    private NavMeshAgent _navMeshAgent;

    public Transform[] waypoints;

    private int currentWaypointIndex;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.SetDestination(waypoints[currentWaypointIndex].position);
    }

    void Update()
    {
        if (_navMeshAgent.remainingDistance < _navMeshAgent.stoppingDistance){
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            _navMeshAgent.SetDestination(waypoints[currentWaypointIndex].position);
        }
    }
}
