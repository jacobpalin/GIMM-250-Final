using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSame : MonoBehaviour
{
    //sets speed for rotating objects
    private float rotSpeed = 150.0f;

    // Update is called once per frame
    void Update()
    {
        //calls rotating method
        Rotating();
    }
    //rotating method checks if the player is pressing E or Q and rotates objects clockwise or counter-clockwise respectively
    private void Rotating()
    {
        if (Input.GetKey(KeyCode.E))
        {
            //uses the transform component in an object to rotate on the z axis at a set speed, time.deltatime keeps the rotation going as long as the button is pressed
            transform.Rotate(Vector3.forward, -rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward, rotSpeed * Time.deltaTime);
        }
    }
}