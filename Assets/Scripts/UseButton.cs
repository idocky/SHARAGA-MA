using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseButton : MonoBehaviour
{
    public static class isUseButton
    {
        public static bool buttonActive = false;
        

        
    }
   public void setButtonActive()
        {
        isUseButton.buttonActive = true;
        Debug.Log("���������");
        Invoke("setButtonOff", 0.5f);
        Debug.Log("���������22");

    }

    public void setButtonOff()
    {
        isUseButton.buttonActive = false;
    }

    
}
