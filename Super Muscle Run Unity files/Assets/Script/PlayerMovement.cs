using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public int score = 0;
    public Text scoreText;

    void Update()
    {
        scoreText.text = "Score : "+score.ToString();
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float MoveHorizontal = Input.GetAxis("Horizontal") * speed;
        
        MoveHorizontal *= Time.deltaTime;
        

        // Move translation along the object's z-axis
        transform.Translate(0, 0, speed * Time.deltaTime);

        transform.Translate(MoveHorizontal, 0, 0);

        if(transform.position.y <= -2f)
        {
            //Restart the level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
