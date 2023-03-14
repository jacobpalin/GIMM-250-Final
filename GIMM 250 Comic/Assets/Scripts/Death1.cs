using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death1 : MonoBehaviour
{
    public bool Undead = true;
    private GameObject Player1;
    private GameObject Checker22;
    private GameObject Checker212;
    private GameObject Checker32;
    private GameObject Checker312;
    private GameObject Checker42;
    private GameObject Checker412;
    private GameObject STOPPER0;
    private GameObject STOPPER120;
    private GameObject STOPPER22;
    private GameObject STOPPER32;
    private GameObject STOPPER42;
    private GameObject STOPPER52;
    private GameObject STOPPER62;
    private GameObject STOPPER72;
    private GameObject STOPPER82;
    private GameObject STOPPER92;
    private GameObject STOPPER102;
    private GameObject STOPPER112;
    private GameObject STOPPER122;
    private GameObject STOPPER132;
    private GameObject STOPPER142;

    private CapsuleCollider2D Player;
    private Collider2D Checker2;
    private Collider2D Checker21;
    private Collider2D Checker3;
    private Collider2D Checker31;
    private Collider2D Checker4;
    private Collider2D Checker41;
    private Collider2D STOPPER;
    private Collider2D STOPPER1;
    private Collider2D STOPPER2;
    private Collider2D STOPPER3;
    private Collider2D STOPPER4;
    private Collider2D STOPPER5;
    private Collider2D STOPPER6;
    private Collider2D STOPPER7;
    private Collider2D STOPPER8;
    private Collider2D STOPPER9;
    private Collider2D STOPPER10;
    private Collider2D STOPPER11;
    private Collider2D STOPPER12;
    private Collider2D STOPPER13;
    private Collider2D STOPPER14;
    
    // Start is called before the first frame update
    void Start()
    {
        Player1 = GameObject.Find("Player");
        Checker22 = GameObject.Find("Checker2");
        Checker212 = GameObject.Find("Checker2 (1)");
        Checker32 = GameObject.Find("Checker3");
        Checker312 = GameObject.Find("Checker3 (1)");
        Checker42 = GameObject.Find("Checker4");
        Checker412 = GameObject.Find("Checker4 (1)");
        STOPPER0 = GameObject.Find("STOPPER");
        STOPPER120 = GameObject.Find("STOPPER (1)");
        STOPPER22 = GameObject.Find("STOPPER (2)");
        STOPPER32 = GameObject.Find("STOPPER (3)");
        STOPPER42 = GameObject.Find("STOPPER (4)");
        STOPPER52 = GameObject.Find("STOPPER (5)");
        STOPPER62 = GameObject.Find("STOPPER (6)");
        STOPPER72 = GameObject.Find("STOPPER (7)");
        STOPPER82 = GameObject.Find("STOPPER (8)");
        STOPPER92 = GameObject.Find("STOPPER (9)");
        STOPPER102 = GameObject.Find("STOPPER (10)");
        STOPPER112 = GameObject.Find("STOPPER (11)");
        STOPPER122 = GameObject.Find("STOPPER (12)");
        STOPPER132 = GameObject.Find("STOPPER (13)");
        STOPPER142 = GameObject.Find("STOPPER (14)");
        STOPPER = STOPPER0.transform.GetComponent<Collider2D>();
        STOPPER1 = STOPPER120.transform.GetComponent<Collider2D>();
        STOPPER2 = STOPPER22.transform.GetComponent<Collider2D>();
        STOPPER3 = STOPPER32.transform.GetComponent<Collider2D>();
        STOPPER5 = STOPPER52.transform.GetComponent<Collider2D>();
        STOPPER6 = STOPPER62.transform.GetComponent<Collider2D>();
        STOPPER7 = STOPPER72.transform.GetComponent<Collider2D>();
        STOPPER8 = STOPPER82.transform.GetComponent<Collider2D>();
        STOPPER10 = STOPPER102.transform.GetComponent<Collider2D>();
        STOPPER11 = STOPPER112.transform.GetComponent<Collider2D>();
        STOPPER12 = STOPPER122.transform.GetComponent<Collider2D>();
        STOPPER13 = STOPPER132.transform.GetComponent<Collider2D>();
        Checker2 = Checker22.transform.GetComponent<Collider2D>();
        Checker21 = Checker212.transform.GetComponent<Collider2D>();
        Checker3 = Checker32.transform.GetComponent<Collider2D>();
        Checker31 = Checker312.transform.GetComponent<Collider2D>();
        Checker4 = Checker42.transform.GetComponent<Collider2D>();
        Checker41 = Checker412.transform.GetComponent<Collider2D>();
        Player = Player1.transform.GetComponent<CapsuleCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        /* (Player.IsTouching(Checker2) || Player.IsTouching(Checker21) || Player.IsTouching(Checker3) || Player.IsTouching(Checker31) || Player.IsTouching(Checker4) || Player.IsTouching(Checker41))
        {
            if (Undead == true)
            {
                SceneManager.LoadScene(1);
            }
        }
        
       if(Player.IsTouching(STOPPER) || Player.IsTouching(STOPPER1) || Player.IsTouching(STOPPER2) || Player.IsTouching(STOPPER3) || Player.IsTouching(STOPPER4) || Player.IsTouching(STOPPER5) || Player.IsTouching(STOPPER6) || Player.IsTouching(STOPPER7) || Player.IsTouching(STOPPER8) || Player.IsTouching(STOPPER10) || Player.IsTouching(STOPPER11) || Player.IsTouching(STOPPER12) || Player.IsTouching(STOPPER13) || Player.IsTouching(STOPPER14))
        {
            Undead = false;
        }
       else
        {
            Undead = true;
        }
        */

    }
}
