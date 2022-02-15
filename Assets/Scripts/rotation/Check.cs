using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check : UseButton
{
    public Collider2D hero;
    private bool heroToSecond = false;
    private void Start()
    {
        isUseButton.buttonActive = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == hero)
        {
            heroToSecond = true;
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == hero)
        {
            heroToSecond = false;
        }
    }

    private void Update()
    {
        if( heroToSecond == true && isUseButton.buttonActive == true)
        {
            SceneManager.LoadScene("SecondFloor", LoadSceneMode.Single);
        }
    }

}
