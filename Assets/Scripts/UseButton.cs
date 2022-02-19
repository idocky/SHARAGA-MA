using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class isUseButton
{
    public static bool buttonActive = false;
}
public class UseButton : MonoBehaviour
{
   public void setButtonActive()
   {
        isUseButton.buttonActive = true;
        Invoke("setButtonOff", 0.5f);
    }

    public void setButtonOff()
    {
        isUseButton.buttonActive = false;
    }
}
