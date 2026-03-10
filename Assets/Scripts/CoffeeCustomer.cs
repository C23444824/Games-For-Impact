using System;
using UnityEngine;
using UnityEngine.AI;

public class CoffeeCustomer : MonoBehaviour
{
    public GameObject Till;
    private NavMeshAgent navMesh;
    public bool collected = false;
    private void Start()
    {
        navMesh = gameObject.GetComponent<NavMeshAgent>();
        navMesh.SetDestination(Till.transform.position);
    }
}
