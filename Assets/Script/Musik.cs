using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musik : MonoBehaviour
{
    public static bool IsOn;

    void Update()
    {
        if (!IsOn)
        {
            GetComponent<Image>().color = Color.green;
            PlayerPrefs.SetInt("Musik", 1);
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            PlayerPrefs.SetInt("Musik", 0);
        }
    }
    public void OnClick()
    {
        if (IsOn)
        {
            IsOn = false;
        }
        else
        {
            IsOn = true;
        }
    }
}
