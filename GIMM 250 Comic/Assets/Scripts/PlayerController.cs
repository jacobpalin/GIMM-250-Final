using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// movement code gotten from this video https://www.youtube.com/watch?v=n4N9VEA2GFo&ab_channel=DistortedPixelStudios

public class PlayerController : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    public float speed = 1;
    private CapsuleCollider2D capsuleCollider2D;
    private Rigidbody2D rigidbody2d;

    public Animator animator;

    void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        capsuleCollider2D = transform.GetComponent<CapsuleCollider2D>();

        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if (movement < 0)
        {
            transform.localScale = new Vector3(-0.35225f, 0.35225f, 0.7045f);
        }

        if (movement > 0)
        {
            transform.localScale = new Vector3(0.35225f, 0.35225f, 0.7045f);
        }

        animator.SetFloat("running", Mathf.Abs(movement));

        // Wont be using jump for my levels

        /*if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 15f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;

            animator.SetTrigger("jumping");
        }*/

    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(capsuleCollider2D.bounds.center, capsuleCollider2D.bounds.size, 0f, Vector2.down, .1f, platformLayerMask);
        return raycastHit2D.collider != null;
    }
}