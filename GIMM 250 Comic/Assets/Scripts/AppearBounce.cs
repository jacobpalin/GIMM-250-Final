using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearBounce : MonoBehaviour
{
    public GameObject boxTwo;
    public GameObject bounce;

    void Update()
    {
       if(boxTwo.transform.position.x >= 30)
       {
            bounce.SetActive(true); //activates game object
       }
       else
       {
            bounce.SetActive(false);
       }
    }
}
