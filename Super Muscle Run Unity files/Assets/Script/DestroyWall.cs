using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.GetComponent<playerStrength>().strenght >= 3)
            {
                collision.gameObject.GetComponent<playerStrength>().strenght -= 1;
                Destroy(gameObject);
            }
        }
    }
    
}
