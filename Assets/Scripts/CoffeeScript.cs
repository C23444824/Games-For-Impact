using System;
using UnityEngine;

public class CoffeeScript : MonoBehaviour
{
    private Collider colr;

    private void Start()
    {
        colr = gameObject.GetComponent<Collider>();
        Debug.Log(colr);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (other.CompareTag("Customer"))
        {
            
            Debug.Log("Customer detected");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("STAY");
    }
}
