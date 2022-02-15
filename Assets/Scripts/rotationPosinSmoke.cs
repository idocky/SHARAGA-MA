using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationPosinSmoke : MonoBehaviour
{
    private SpriteRenderer sp;
    public GameObject smoke;

    private void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        sp.transform.position = new Vector3 (sp.transform.position.x - 0.01f, sp.transform.position.y,0);
    }

    private void Update()
    {
        if(sp.transform.position.x < 0)
        {
            sp.transform.position = new Vector3(47f, sp.transform.position.y, 0);
        }
    }
}
