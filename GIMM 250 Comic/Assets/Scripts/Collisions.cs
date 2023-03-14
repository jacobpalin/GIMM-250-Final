using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    //grabs the blockade object in Unity and sets it as a variable
    public GameObject blockade;

    //initial x value for moving the coins to the collected section of the puzzle
    private int coinPos = 91; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if the player collides with an object with the 'coin' tag, it moves that object to (91, -16, 0) where the first 'empty' coin slot is in the scene to show that it has been collected, then it adds 7 to coinPos which will make the next collected coin go 7 units positive in the x direction
        if(other.transform.tag == "coin")
        {
            other.transform.position = new Vector3(coinPos, -16, 0);
            coinPos = coinPos + 7;
        }

        //the last possible value for coinPos is 119 since there are only 5 coins needed and when coinPos = 119, the blockade is removed clearing the path to the door
        if(coinPos == 119)
        {
            blockade.SetActive(false);
        }
    }
}
