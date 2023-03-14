using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SameBox : MonoBehaviour
{
    private GameObject Box2;
    private GameObject Box1;
    private GameObject Player;
    private CapsuleCollider2D PlayerCollider;
    private Collider2D Boxxer;
    private Collider2D Boxxer2;
    private float asdf;
    // Start is called before the first frame update
    void Start()
    {
        Box2 = GameObject.Find("Boxxy");
        Box1 = GameObject.Find("Square");
        Player = GameObject.Find("Player");
        PlayerCollider = Player.transform.GetComponent<CapsuleCollider2D>();
        Boxxer = Box1.transform.GetComponent<Collider2D>();
        Boxxer2 = Box2.transform.GetComponent<Collider2D>();
        asdf = Box1.transform.position.x + Box2.transform.position.x;


    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerCollider.IsTouching(Boxxer))
        {
            
            Box2.transform.position = new Vector3(-Box1.transform.position.x + asdf, Box2.transform.position.y, Box2.transform.position.z);
        }
        if (PlayerCollider.IsTouching(Boxxer2))
        {
            Box1.transform.position = new Vector3(-Box2.transform.position.x + asdf, Box1.transform.position.y, Box1.transform.position.z);
        }
    }
}
