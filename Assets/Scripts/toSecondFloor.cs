using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toSecondFloor : MonoBehaviour
{
    public Collider2D cl;
    public GameObject arrow;

    private GameObject cloneArrow;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == cl)
        {
            cloneArrow = Instantiate(arrow, new Vector3(-11.7f,-0.37f,0), Quaternion.identity);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == cl)
        {
            if (cloneArrow)
            {
                Destroy(cloneArrow);
            }

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

    }

    public void SceneLoad()
    {
        SceneManager.LoadScene("Main");
    }
   
}
