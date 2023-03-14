using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// movement code gotten from this video https://www.youtube.com/watch?v=n4N9VEA2GFo&ab_channel=DistortedPixelStudios

public class PlayerControllerJacob : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    public float speed = 1;
    private CapsuleCollider2D capsuleCollider2D;
    private Rigidbody2D rigidbody2d;

    Animator animator;

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

        animator.SetFloat("running", Mathf.Abs(movement));

        /*if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 15f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;

            animator.SetTrigger("jumping");

        }

        if (!IsGrounded())
        {
            animator.SetTrigger("jumping");

        }*/

        if (movement < 0)
        {
            transform.localScale = new Vector2(-1f, 1f);
        }
        else if (movement > 0)
        {
            transform.localScale = new Vector2(1f, 1f);
        }
    }
    /*private bool IsGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(capsuleCollider2D.bounds.center, capsuleCollider2D.bounds.size, 0f, Vector2.down, .1f, platformLayerMask);
        return raycastHit2D.collider != null;
    }*/
}