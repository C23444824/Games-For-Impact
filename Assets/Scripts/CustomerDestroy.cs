using System;
using UnityEngine;

public class CustomerDestroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Customer") && other.GetComponent<CoffeeCustomer>().collected)
        {
            Debug.Log("Collected coffee customer detected");
            Destroy(other.gameObject);
        }
    }
}
