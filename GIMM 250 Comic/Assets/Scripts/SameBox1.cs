using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SameBox1 : MonoBehaviour
{
    private GameObject Box1;
    private GameObject Box2;
    private GameObject Box3;
    private GameObject Box4;
    private GameObject Player;
    private GameObject Pressure;
    private GameObject Pressure1;
    private GameObject Pressure2;
    private GameObject Blue;
    private GameObject Red;
    private GameObject Yellow;
    private GameObject Door;
    private CapsuleCollider2D PlayerCollider;
    private Collider2D Boxxer;
    private Collider2D Boxxer2;
    private Collider2D EscapeDoor;
    private Collider2D Boxxer3;
    private Collider2D Boxxer4;
    private Collider2D BluePressure;
    private Collider2D RedPressure;
    private Collider2D YellowPressure;
    private float asdf;
    private float asdf2;
    private float asdf3;
    // Start is called before the first frame update
    void Start()
    {
        Box4 = GameObject.Find("Box4");
        Box3 = GameObject.Find("Box3");
        Box2 = GameObject.Find("Box2");
        Box1 = GameObject.Find("Box");
        Blue = GameObject.Find("blue");
        Red = GameObject.Find("red");
        Yellow = GameObject.Find("yellow");
        Player = GameObject.Find("Player");
        Pressure = GameObject.Find("Pressure");
        Pressure1 = GameObject.Find("Pressure1");
        Pressure2 = GameObject.Find("Pressure2");
        Door = GameObject.Find("EscapeDoor (2)");
        PlayerCollider = Player.transform.GetComponent<CapsuleCollider2D>();
        Boxxer = Box1.transform.GetComponent<Collider2D>();
        Boxxer2 = Box2.transform.GetComponent<Collider2D>();
        Boxxer3 = Box3.transform.GetComponent<Collider2D>();
        Boxxer4 = Box4.transform.GetComponent<Collider2D>();
        BluePressure = Pressure.transform.GetComponent<Collider2D>();
        RedPressure = Pressure1.transform.GetComponent<Collider2D>();
        YellowPressure = Pressure2.transform.GetComponent<Collider2D>();
        asdf = Box1.transform.position.x + Box4.transform.position.x;
        asdf2 = Box1.transform.position.x + Box4.transform.position.x;
        asdf3 = Box1.transform.position.x + Box4.transform.position.x;
        Blue.SetActive(true);
        Red.SetActive(true);
        Yellow.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerCollider.IsTouching(Boxxer))
        {
            
            Box4.transform.position = new Vector3(-Box1.transform.position.x + asdf, Box4.transform.position.y, Box4.transform.position.z);
        }
        if (PlayerCollider.IsTouching(Boxxer2))
        {
            Box4.transform.position = new Vector3(-Box2.transform.position.x + asdf, Box4.transform.position.y, Box4.transform.position.z);
        }
        if (PlayerCollider.IsTouching(Boxxer3))
        {

            Box4.transform.position = new Vector3(-Box3.transform.position.x + asdf, Box4.transform.position.y, Box4.transform.position.z);
        }
        if (Boxxer4.IsTouching(BluePressure))
        {
            Blue.SetActive(false);
        }
        else
        {
            Blue.SetActive(true);
        }
        if (Boxxer4.IsTouching(YellowPressure))
        {
            Yellow.SetActive(false);
        }
        else
        {
            Yellow.SetActive(true);
        }
        if (Boxxer4.IsTouching(RedPressure))
        {
            Red.SetActive(false);
        }
        else
        {
            Red.SetActive(true);
        }
        /*if (Input.GetKeyDown(KeyCode.E) && PlayerCollider.IsTouching(EscapeDoor))
        {
            PlayerControllerRedacted.Future += 1;

            SceneManager.LoadScene(0);
        }*/
    }
}
