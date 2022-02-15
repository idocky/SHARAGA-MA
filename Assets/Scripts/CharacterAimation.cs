using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAimation : MonoBehaviour
{
    public Joystick joystick;
    
    private float moveInput;
    
    private Animator anim;
    private Rigidbody2D rb;
  

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    public void Update()
    {
        
        moveInput = joystick.Horizontal;
        if(moveInput > 0 || moveInput < 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
        if(Mathf.Abs(rb.velocity.y) > 0.001)
        {
            anim.SetBool("isJumping", true);
        }
        else
        {
            anim.SetBool("isJumping", false);
        }
    }
}
