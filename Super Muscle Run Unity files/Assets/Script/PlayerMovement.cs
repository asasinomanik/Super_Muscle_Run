using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float MoveHorizontal = Input.GetAxis("Horizontal") * speed;
        float MoveVertical = Input.GetAxis("Vertical") * speed;


        // Make it move 10 meters per second instead of 10 meters per frame...
        MoveHorizontal *= Time.deltaTime;
        MoveVertical *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, MoveVertical);

        // Rotate around our y-axis
        transform.Translate(MoveHorizontal, 0, 0);
    }
}
