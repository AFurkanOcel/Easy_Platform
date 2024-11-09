using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvlsscript : MonoBehaviour
{
    public Button button2, button3, button4, button5, button6;
    public static bool lvl1, lvl2, lvl3, lvl4, lvl5;

    void Update()
    {
        if (lvl1 == true)
        {
            button2.interactable = true;
        }
        if (lvl2 == true)
        {
            button3.interactable = true;
        }
        if (lvl3 == true)
        {
            button4.interactable = true;
        }
        if (lvl4 == true)
        {
            button5.interactable = true;
        }
        if (lvl5 == true)
        {
            button6.interactable = true;
        }
    }
}
