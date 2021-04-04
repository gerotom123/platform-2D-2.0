using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float RunSpeed = 2;

    public float JumpSpeed = 3;

    public CheckGround checkground;

    
    
    Rigidbody2D rb2D;


    public bool BetterJump = false;

    public float FallMultiplier = 0.5f;

    public float LowJumpMultiplier = 1f;

    public  SpriteRenderer SpriteRenderer;

    public Animator Animator;   

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(RunSpeed, rb2D.velocity.y);
            SpriteRenderer.flipX = false;
            Animator.SetBool("Run", true);
        }

        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-RunSpeed, rb2D.velocity.y);
            SpriteRenderer.flipX = true;
            Animator.SetBool("Run", true);
        }

        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            Animator.SetBool("Run", false);
        }

        if (Input.GetKey("space") && checkground.isGrounded) 
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, JumpSpeed); 
        }

        if (!checkground.isGrounded)
        {
            Animator.SetBool("Jump", true);
            Animator.SetBool("Run", false);

        }
        if (checkground.isGrounded)
        {
            Animator.SetBool("Jump", false);
        }

        if (BetterJump)
        {
            if (rb2D.velocity.y<0)
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (FallMultiplier) * Time.deltaTime;
            }
            if (rb2D.velocity.y>0 && !Input.GetKey("space"))
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (LowJumpMultiplier) * Time.deltaTime;
            }

        }
    }
}
