using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public int sceneIndex;
    public GameObject sign;
    public GameController gameController;

    private void OnTriggerStay2D(Collider2D collision)
    {
        sign.SetActive(true);
        if (isUseButton.buttonActive)
            gameController.StartLoad(sceneIndex);
            //SceneManager.LoadScene(sceneIndex);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sign.SetActive(false);
    }
}
