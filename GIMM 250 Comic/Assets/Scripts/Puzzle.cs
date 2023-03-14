using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle : MonoBehaviour
{
    public Collider2D Escape;
    private Collider2D Checker;
    private Collider2D First;
    private Collider2D Second;
    private Collider2D Third;
    private Collider2D Fourth;
    private GameObject Square;
    private GameObject Circle;
    private GameObject Circle1;
    private GameObject Circle2;
    private GameObject Circle3;
    private GameObject Correct;
    SpriteRenderer m_SpriteRenderer;
    private GameObject Player;
    private GameObject Door;
    public CapsuleCollider2D PlayerCollider;


    public float Truth;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        Door = GameObject.Find("EscapeDoor");
        Square = GameObject.Find("Checker");
        Circle = GameObject.Find("Circle");
        Circle1 = GameObject.Find("Circle (1)");
        Circle2 = GameObject.Find("Circle (2)");
        Circle3 = GameObject.Find("Circle (3)");
        Correct = GameObject.Find("Square (7)");
        Checker = Square.transform.GetComponent<Collider2D>();
        First = Circle.transform.GetComponent<Collider2D>();
        Second = Circle1.transform.GetComponent<Collider2D>();
        Third = Circle2.transform.GetComponent<Collider2D>();
        Fourth = Circle3.transform.GetComponent<Collider2D>();
        PlayerCollider = Player.transform.GetComponent<CapsuleCollider2D>();
        Escape = Door.transform.GetComponent<Collider2D>();
        m_SpriteRenderer = Correct.GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.red;
        Truth = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Checker.IsTouching(Second) && Truth == 0)
        {
            Truth = 1;
        }
        else if (Checker.IsTouching(Second) && Truth > 1)
        {
            Truth = 0;
        }
        if (Checker.IsTouching(First) && Truth == 1)
        {
            Truth = 2;
        }
        else if (Checker.IsTouching(First) && Truth > 2)
        {
            Truth = 0;
        }
        if (Checker.IsTouching(Fourth) && Truth == 2)
        {
            Truth = 3;
        }
        else if (Checker.IsTouching(Fourth) && (Truth > 3 || Truth < 2))
        {
            Truth = 0;
        }
        if (Checker.IsTouching(Third) && Truth == 3)
        {
            Truth = 4;
        }
        else if (Checker.IsTouching(Fourth) && (Truth > 4 || Truth < 3))
        {
            Truth = 0;
        }
        if (Truth == 4)
        {
            m_SpriteRenderer.color = Color.green;


        }
        if (PlayerCollider.IsTouching(Escape) && Truth == 4 && Input.GetKeyDown(KeyCode.E))
        {
            PlayerControllerRedacted.Future += 1;

            SceneManager.LoadScene(0);

        }


    }
   

}
