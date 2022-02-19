using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    public float jumpForce = 5f;
    public Joystick joystick;
    
    private float jumpInput;
    private float moveInput;
    private SpriteRenderer sr;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        isUseButton.buttonActive = false;
    }
    private void FixedUpdate()
    {
        moveInput = joystick.Horizontal;
        jumpInput = joystick.Vertical;
        
        
        //rb.transform.position += new Vector3(a, 0f) * speed;
        //if(moveInput > 0.5 || moveInput < -0.5)
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (moveInput < 0)
        {
            sr.flipX = true;
        }
        else if (moveInput > 0)
        {
            sr.flipX = false;
        }
    }
    private void Update()
    {
        if (jumpInput > 0.5 && Mathf.Abs(rb.velocity.y) < 0.05f && rb.transform.position.y < -2f)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }

}
