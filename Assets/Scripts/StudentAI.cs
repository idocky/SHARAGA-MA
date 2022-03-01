using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentAI : MonoBehaviour
{
    public bool streetStudent;
    public float speed = 10f;
    public GameObject sprite;
    public Transform[] Targets = new Transform[10];
    public Sprite[] walkSprite = new Sprite[4];
    Transform curTarget = null;

    private void Start()
    {
        StartCoroutine(Walk());
    }

    void Update()
    {
        if (streetStudent)
        {
            if (curTarget == null || transform.position == curTarget.position)
                SetTarget();
        }
        else
        {
            if (curTarget == null)
                SetTarget();
            if (transform.position == curTarget.position) Destroy(gameObject);
        }
        transform.position = Vector3.MoveTowards(transform.position, curTarget.transform.position, speed * Time.deltaTime);
    }

    void SetTarget()
    {
        curTarget = Targets[Random.Range(0, Targets.Length)];
        if (curTarget.transform.position.x >= transform.position.x)
            sprite.transform.Rotate(0, 0, 0);
        else
            sprite.transform.Rotate(0, 180, 0);
    }

    IEnumerator Walk()
    {
        yield return new WaitForSeconds(0.25f);
        sprite.GetComponent<SpriteRenderer>().sprite = walkSprite[0];
        yield return new WaitForSeconds(0.25f);
        sprite.GetComponent<SpriteRenderer>().sprite = walkSprite[1];
        yield return new WaitForSeconds(0.25f);
        sprite.GetComponent<SpriteRenderer>().sprite = walkSprite[2];
        yield return new WaitForSeconds(0.25f);
        sprite.GetComponent<SpriteRenderer>().sprite = walkSprite[3];
        StartCoroutine(Walk());
    }
}