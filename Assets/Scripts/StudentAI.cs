using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentAI : MonoBehaviour
{
    public float speed = 10f;
    public Transform[] Targets = new Transform[10];
    Transform curTarget = null;

    void Update()
    {
        if(curTarget == null || transform.position == curTarget.position)
            curTarget = Targets[Random.Range(0, Targets.Length)];
        transform.position = Vector3.MoveTowards(transform.position, new Vector2(curTarget.position.x, transform.position.y), speed * Time.deltaTime);
    }
}