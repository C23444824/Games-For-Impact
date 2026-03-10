using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class CoffeePickup : MonoBehaviour
{
    public GameObject nextTarget;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Customer"))
        {
            other.GetComponent<NavMeshAgent>().isStopped = true;
            Debug.Log("Triggered");
            StartCoroutine(nextLocation(other.gameObject));
            Debug.Log("Executed");
        }
    }

    public IEnumerator nextLocation(GameObject other)
    {
        
        
        yield return new WaitForSeconds(5);
        other.GetComponent<NavMeshAgent>().SetDestination(nextTarget.transform.position);
        other.GetComponent<NavMeshAgent>().isStopped = false;
        Debug.Log(nextTarget.transform.position);
    }
}
