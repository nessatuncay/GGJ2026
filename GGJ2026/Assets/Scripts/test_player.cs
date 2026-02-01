using System;
using UnityEngine;

public class test_player : MonoBehaviour
{

    public float speed = 5f;
    public float jumpForce = 10f;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // LEFT & RIGHT (Arrow keys)
        if (Input.GetKey(KeyCode.A))
            rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
        else if (Input.GetKey(KeyCode.D))
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        else
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);

        
        // JUMP (Space bar)
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    
    }
}






