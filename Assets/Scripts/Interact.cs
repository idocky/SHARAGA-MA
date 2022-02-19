using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public int sceneIndex;
    public GameObject sign;

    private void OnTriggerStay2D(Collider2D collision)
    {
        sign.SetActive(true);
        if (isUseButton.buttonActive)
            SceneManager.LoadScene(sceneIndex);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sign.SetActive(false);
    }
}
