using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int curScene = 0;
    public GameObject[] scenes = new GameObject[5];
    public Animator crossFade;

    public void StartLoad(int sceneIndex)
    {
        StartCoroutine(Load(sceneIndex));
    }

    IEnumerator Load(int sceneIndex)
    {
        crossFade.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        scenes[curScene].SetActive(false);
        scenes[sceneIndex].SetActive(true);
        curScene = sceneIndex;
        crossFade.SetTrigger("End");
    }
}
