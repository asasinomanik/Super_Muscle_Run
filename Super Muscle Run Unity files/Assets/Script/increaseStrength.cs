using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseStrength : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<playerStrength>().strenght += 1;
            Destroy(gameObject);
        }
    }
}
