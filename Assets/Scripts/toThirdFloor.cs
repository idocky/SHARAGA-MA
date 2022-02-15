using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toThirdFloor : MonoBehaviour
{
    public Collider2D cl;
    public GameObject arrow;
    private GameObject cloneArrow;




    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == cl)
        {
            cloneArrow = Instantiate(arrow, arrow.transform.position, Quaternion.identity);
            
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
