using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAndOff : MonoBehaviour
{
    private Collider2D On, On2;

    private GameObject E;
    private GameObject E2;
    private GameObject Player;
    private GameObject LaserGun;
    private GameObject LaserGun1;
    private CapsuleCollider2D PlayerCollider;
    public float Truth;
    // Start is called before the first frame update
    void Start()
    {
        E = GameObject.Find("E");
        E2 = GameObject.Find("E2");
        Player = GameObject.Find("Player");
        LaserGun = GameObject.Find("LaserGun");
        LaserGun1 = GameObject.Find("LaserGun1");
        PlayerCollider = Player.transform.GetComponent<CapsuleCollider2D>();
        On = E.transform.GetComponent<Collider2D>();
        On2 = E2.transform.GetComponent<Collider2D>();
        LaserGun.SetActive(true);
        LaserGun1.SetActive(true);
        Truth = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerCollider.IsTouching(On) && Truth == 0)
        {
            LaserGun.SetActive(false);
            LaserGun1.SetActive(false);
            Truth = 1;
        }
        else if (Input.GetKeyDown(KeyCode.E) && PlayerCollider.IsTouching(On) && Truth == 1)
        {
            LaserGun.SetActive(true);
            LaserGun1.SetActive(true);
            Truth = 0;
        }
        if (Input.GetKeyDown(KeyCode.E) && PlayerCollider.IsTouching(On2) && Truth == 0)
        {
            LaserGun.SetActive(false);
            LaserGun1.SetActive(false);
            Truth = 1;
        }
        else if (Input.GetKeyDown(KeyCode.E) && PlayerCollider.IsTouching(On2) && Truth == 1)
        {
            LaserGun.SetActive(true);
            LaserGun1.SetActive(true);
            Truth = 0;
        }

    }
}
