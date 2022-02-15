using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateDoor : MonoBehaviour
{
    private Animator am;

    private void Awake()
    {
        am = GetComponent<Animator>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            am.SetBool("nearPlayer", true);
        }
        

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            am.SetBool("nearPlayer", false);
        }
    }
}
