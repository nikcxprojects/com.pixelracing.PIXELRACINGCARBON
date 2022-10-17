using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusikSet : MonoBehaviour
{
    public AudioSource Audio;
    void Update()
    {
        if (PlayerPrefs.GetInt("Musik") == 1)
        {
            Audio.volume = 1f;
        }
        else
        {
            Audio.volume = 0f;
        }
    }
}
