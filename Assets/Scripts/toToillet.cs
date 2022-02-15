using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toToillet : MonoBehaviour
{
    public Collider2D cl;
    public GameObject arrow;
    private GameObject cloneArrow;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == cl)
        {
            cloneArrow = Instantiate(arrow, new Vector3(-7.88f, -0.51f, -0.53f), Quaternion.Euler(67.19f,4.36f,25.52f));
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
}
