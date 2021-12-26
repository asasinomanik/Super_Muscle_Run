using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyWall : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<playerStrength>().strenght >= 3)
            {
                other.gameObject.GetComponent<playerStrength>().strenght -= 1;
                Destroy(gameObject);
            }
            else 
            {
                Destroy(other.gameObject,0.2f);

                //Restart the level
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
            }
        }
    }
    
}
