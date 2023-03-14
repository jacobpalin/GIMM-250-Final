using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask; //uses layers in the inspector so player can actually jump 
    private BoxCollider2D playerCollider; 
    private Rigidbody2D rigidbody2d; 

    [Header("Variables")]

    public float speed = 1; //player speed
    public float jumpVelocity = 15f; //jump velocity

    [Header("Animator")]

    public Animator animator;

    void Awake()
    {
        //references
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        playerCollider = transform.GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        PlayerMovement();
    }

    //ground check using the players collider
    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(playerCollider.bounds.center, playerCollider.bounds.size, 0f, Vector2.down, .1f, platformLayerMask);
        return raycastHit2D.collider != null;
    }

    private void PlayerMovement()
    {
        //player input
        var movement = Input.GetAxis("Horizontal");

        animator.SetFloat("running", Mathf.Abs(movement));

        //moves along the X axis
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        //flips character
        if (movement < 0)
        {
            transform.localScale = new Vector3(-0.75f, 0.75f, 0.5f);
        }

        if (movement > 0)
        {
            transform.localScale = new Vector3(0.75f, 0.75f, 0.5f);
        }

        //allows player to jump when grounded
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.velocity = Vector2.up * jumpVelocity;

            animator.SetTrigger("jumping");
        }
    }
}