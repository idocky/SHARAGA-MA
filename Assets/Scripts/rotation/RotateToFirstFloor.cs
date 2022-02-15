using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateToFirstFloor : UseButton
{
    public Collider2D hero;
    private bool heroToFirst = false;

    private void Start()
    {
        isUseButton.buttonActive = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == hero)
        {
            heroToFirst = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == hero)
        {
            heroToFirst = false;
        }
    }

    private void Update()
    {
        if (heroToFirst == true && isUseButton.buttonActive == true)
        {
            SceneManager.LoadScene("FirstFloor", LoadSceneMode.Single);
        }
    }

    private void fromStToFF()
    {
        Instantiate(hero, new Vector3(12.11f, -2.96f, 0), Quaternion.identity);
    }
}
