using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

// code gotten from this video https://www.youtube.com/watch?v=n4N9VEA2GFo&ab_channel=DistortedPixelStudios

public class PlayerControllerRedacted : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    public float speed = 1;
    public VideoPlayer video;
    private CapsuleCollider2D capsuleCollider2D;
    private Rigidbody2D rigidbody2d;
    private SpriteRenderer flipper;
    private GameObject Player;
    private GameObject Camera;
    private GameObject Touch;
    private Collider2D Switch;
    private GameObject Touch1;
    private Collider2D Switch1;
    private GameObject Touch2;
    private Collider2D Switch2;
    private GameObject Touch3;
    private Collider2D Switch3;
    public static int Future = 0;
    
  


    public bool Teleport = true;
    public Animator animator;

    void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        capsuleCollider2D = transform.GetComponent<CapsuleCollider2D>();
        flipper = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        Player = GameObject.Find("Player");
        Camera = GameObject.Find("Main Camera");
        Touch = GameObject.Find("Switch");
        Switch = Touch.transform.GetComponent<Collider2D>();
        Touch1 = GameObject.Find("Switch (1)");
        Switch1 = Touch1.transform.GetComponent<Collider2D>();
        Touch2 = GameObject.Find("Switch (2)");
        Switch2 = Touch2.transform.GetComponent<Collider2D>();
        Touch3 = GameObject.Find("Switch (3)");
        Switch3 = Touch3.transform.GetComponent<Collider2D>();
    }

    public void Update()
    {
        
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        animator.SetFloat("running", Mathf.Abs(movement));

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 15f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;


            animator.SetTrigger("jumping");
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            flipper.flipX = true;

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            flipper.flipX = false;

        }
        if (Input.GetKeyDown(KeyCode.R) && Teleport == true)
        {
            Camera.transform.position = new Vector3(Camera.transform.position.x, -6.5F, Camera.transform.position.z);
            Player.transform.position = new Vector3(Player.transform.position.x, 12.78F, Player.transform.position.z);
            Teleport = false;
            
        }
        else if (Input.GetKeyDown(KeyCode.R) && Teleport == false)
        {
            Camera.transform.position = new Vector3(Camera.transform.position.x, 1F, Camera.transform.position.z);
            Player.transform.position = new Vector3(Player.transform.position.x, 1.6F, Player.transform.position.z);
            Teleport = true;
            
        }
        if (capsuleCollider2D.IsTouching(Switch) && Input.GetKeyDown(KeyCode.E))
        {
            
            SceneManager.LoadScene(1);
            
        }
        if (capsuleCollider2D.IsTouching(Switch1) && Input.GetKeyDown(KeyCode.E))
        {

            video.Play();

        }
        if (capsuleCollider2D.IsTouching(Switch2) && Input.GetKeyDown(KeyCode.E))
        {

            SceneManager.LoadScene(2);

        }
        if (capsuleCollider2D.IsTouching(Switch3) && Input.GetKeyDown(KeyCode.E))
        {

            SceneManager.LoadScene(3);

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Comic Panel") && Future == 1)
        {
            Player.transform.position = new Vector3(Player.transform.position.x, -1.41F, Player.transform.position.z);
            Future = 0;
        }

        

    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(capsuleCollider2D.bounds.center, capsuleCollider2D.bounds.size, 0f, Vector2.down, .1f, platformLayerMask);
        return raycastHit2D.collider != null;
    }
}