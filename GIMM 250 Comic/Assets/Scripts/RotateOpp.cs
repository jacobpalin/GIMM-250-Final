using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOpp : MonoBehaviour
{
    //sets speed for rotating objects
    private float rotSpeed = 90.0f;
    //grabs game objects from Unity and applies them to variables
    public GameObject ring1;
    public GameObject ring2;
    public GameObject ring3;
    public GameObject fullPuzzle;
    public GameObject flash;
    public GameObject blockade;
    public GameObject canvas;
    //declaring variables that will be used in the update method to grab z rotation values on the rings
    public float ring1Angle;
    public float ring2Angle;
    public float ring3Angle;
    //sets a bool equal to false
    public bool puzzleSolved = false;
    // Update is called once per frame
    void Update()
    {
        //these grab the value of the z rotation in the inspector in Unity, I learned about the localEulerAngles feature here: https://forum.unity.com/threads/solved-how-to-get-rotation-value-that-is-in-the-inspector.460310/
        ring1Angle = ring1.transform.localEulerAngles.z;
        ring2Angle = ring2.transform.localEulerAngles.z;
        ring3Angle = ring3.transform.localEulerAngles.z;
        //calls solved method
        Solved();
    }
    private void Solved()
    {
        //checks if the z rotation in the inspector on the 3 rings is equal to zero which means the puzzle is solved, and then clears the blockade to continue and disables the buttons on the canvas
        if(ring1Angle == 0 && ring2Angle == 0 && ring3Angle == 0 && !puzzleSolved)
        {
            puzzleSolved = true;
            Instantiate(flash);
            blockade.SetActive(false);
            fullPuzzle.SetActive(true);
            canvas.SetActive(false);
        }
    }
    //the following methods are used by the buttons in the canvas to rotate the rings in the puzzle
    //rotates ring 1 CW and ring 3 CCW
    public void Ring1Clockwise()
    {
        //uses the transform component in an object to rotate on the z axis a set amount in this case, 90 degrees in the negative or positive direction
        ring1.transform.Rotate(Vector3.forward, -rotSpeed);
        ring3.transform.Rotate(Vector3.forward, rotSpeed);
    }
    //rotates ring 3 CW and ring 1 CCW
    public void Ring1CClockwise()
    {
        ring1.transform.Rotate(Vector3.forward, rotSpeed);
        ring3.transform.Rotate(Vector3.forward, -rotSpeed);
    }
    //rotates ring 2 CW and ring 1 CCW
    public void Ring2Clockwise()
    {
        ring2.transform.Rotate(Vector3.forward, -rotSpeed);
        ring1.transform.Rotate(Vector3.forward, rotSpeed);
    }
    //rotates ring 1 CW and ring 2 CCW
    public void Ring2CClockwise()
    {
        ring2.transform.Rotate(Vector3.forward, rotSpeed);
        ring1.transform.Rotate(Vector3.forward, -rotSpeed);
    }
    //rotates ring 3 CW and ring 2 CCW
    public void Ring3Clockwise()
    {
        ring3.transform.Rotate(Vector3.forward, -rotSpeed);
        ring2.transform.Rotate(Vector3.forward, rotSpeed);
    }
    //rotates ring 2 CW and ring 3 CCW
    public void Ring3CClockwise()
    {
        ring3.transform.Rotate(Vector3.forward, rotSpeed);
        ring2.transform.Rotate(Vector3.forward, -rotSpeed);
    }
}