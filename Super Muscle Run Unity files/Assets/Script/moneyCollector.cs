using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerMovement>().score += 10; 
            Destroy(gameObject);
        }
    }
}
