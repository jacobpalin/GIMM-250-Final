using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoxes : MonoBehaviour
{
    private GameObject Box2;
    private GameObject Box1;
    private GameObject Player;

    private BoxCollider2D PlayerCollider;
    private BoxCollider2D Boxxer;
    private BoxCollider2D Boxxer2;

    void Start()
    {
        Box2 = GameObject.Find("BoxTwo");
        Box1 = GameObject.Find("BoxOne");
        Player = GameObject.Find("Player Young");

        PlayerCollider = Player.transform.GetComponent<BoxCollider2D>();
        Boxxer = Box1.transform.GetComponent<BoxCollider2D>();
        Boxxer2 = Box2.transform.GetComponent<BoxCollider2D>();
    }
   
    private void MoveBoxesSameDirection()
    {
        if (PlayerCollider.IsTouching(Boxxer))
        {
            Box2.transform.position = new Vector3(Box1.transform.position.x, Box2.transform.position.y, Box2.transform.position.z);
        }
        if (PlayerCollider.IsTouching(Boxxer2))
        {
            Box1.transform.position = new Vector3(Box2.transform.position.x, Box1.transform.position.y, Box1.transform.position.z);
        }
    }

    void Update()
    {
        MoveBoxesSameDirection();
    }
}
