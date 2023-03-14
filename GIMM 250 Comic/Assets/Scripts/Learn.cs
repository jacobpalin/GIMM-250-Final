using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Learn : MonoBehaviour
{
    public GameObject Player;
    public GameObject Escape;
    public GameObject Lol;
    public GameObject Important;
    public GameObject Important2;
    public Collider2D Lollider;
    public Collider2D EscapeDoor;
    public CapsuleCollider2D PlayerCollider;
    public bool Phase = true;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        Lol = GameObject.Find("Lollider");
        Important = GameObject.Find("Important");
        Important2 = GameObject.Find("Important2");
        Escape = GameObject.Find("EscapeDoor (2)");
        Lollider = Lol.transform.GetComponent<Collider2D>();
        EscapeDoor = Escape.transform.GetComponent<Collider2D>();
        PlayerCollider = Player.transform.GetComponent<CapsuleCollider2D>();
        Important2.SetActive(false);
            Important.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerCollider.IsTouching(Lollider))
        {
            if (Phase == true)
            {
                Important2.SetActive(true);
                Important.SetActive(false);
                Phase = false;
            }
            else if (Phase == false)
            {
                Important2.SetActive(false);
                Important.SetActive(true);
                Phase = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && PlayerCollider.IsTouching(EscapeDoor))
        {
            SceneManager.LoadScene(1);
        }
    }
}
