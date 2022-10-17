using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;
    public void OnPause ()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void OnExitPause()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void OnExit()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1f;
        Script_Player.Score = 0f;
    }
}
