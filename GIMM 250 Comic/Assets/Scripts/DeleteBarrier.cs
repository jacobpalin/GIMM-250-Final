using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBarrier : MonoBehaviour
{
    public GameObject boxTwo;
    public GameObject wall;

    private float xPos = 0;

    void Update()
    {
       if(boxTwo.transform.position.x <= xPos)
       {
            wall.SetActive(false); //deactivates game object
       }
    }
}
