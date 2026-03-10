using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class CoffeeSpawner : MonoBehaviour
{
        public Transform[] chairs;
        public GameObject[] Instances;
        public Transform exit;
        private Transform nextTarget;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Customer"))
            {
                other.GetComponent<NavMeshAgent>().isStopped = true;
                Debug.Log("Triggered");
                StartCoroutine(nextLocation(other.gameObject));
                Debug.Log("Executed");
                RandomLocation();
            }
        }
        
        public IEnumerator nextLocation(GameObject other)
        {
            other.gameObject.GetComponent<CoffeeCustomer>().collected = true;
            Debug.Log(other.gameObject.GetComponent<CoffeeCustomer>().collected);
            yield return new WaitForSeconds(2);
            other.GetComponent<NavMeshAgent>().SetDestination(nextTarget.position);
            other.GetComponent<NavMeshAgent>().isStopped = false;
            Debug.Log(nextTarget.position);
        }

        public void RandomLocation()
        {
            nextTarget = chairs[Random.Range(0, chairs.Length)];
            // if (Random.Range(1, 2) == 1)
            // {
            //     nextTarget = exit;
            // }
            // else
            // {
            //     
            // }
            Debug.Log(nextTarget.gameObject);
        }
}
