using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private GameObject Ball;
    private Collider2D Deathly;
    private Collider2D Checker;
    private Collider2D Checker2;
    private Collider2D Checker3;
    private Collider2D Checker4;
    private GameObject Check;
    private GameObject Check2;
    private GameObject Check3;
    private GameObject Check4;
    public float min = 2f;
    public float max = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.Find("Ball");
        Check = GameObject.Find("Checker2");
        Check2 = GameObject.Find("Checker2 (1)");
        Check3 = GameObject.Find("Checker3");
        Check4 = GameObject.Find("Checker3 (1)");

        Checker = Check.transform.GetComponent<Collider2D>();
        Checker2 = Check2.transform.GetComponent<Collider2D>();
        Checker3 = Check3.transform.GetComponent<Collider2D>();
        Checker4 = Check4.transform.GetComponent<Collider2D>();

        Deathly = Ball.transform.GetComponent<Collider2D>();

        min = transform.position.x;
        max = transform.position.x + 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Deathly.IsTouching(Checker) || Deathly.IsTouching(Checker2) || Deathly.IsTouching(Checker3) || Deathly.IsTouching(Checker4))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);
    }
}
