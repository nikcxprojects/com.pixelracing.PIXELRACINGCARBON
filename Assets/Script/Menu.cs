using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public Sprite Car1;
    public Sprite Car2;
    public Sprite Car3;

    void Update()
    {
        if (SelectCar.SelectedCar == 0f)
        {
            GetComponent<Image>().sprite = Car1;
        }
        if (SelectCar.SelectedCar == 1f)
        {
            GetComponent<Image>().sprite = Car2;
        }
        if (SelectCar.SelectedCar == 2f)
        {
            GetComponent<Image>().sprite = Car3;
        }
    }
    public void CarSelect()
    {
        SceneManager.LoadScene("CarSelect");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Score()
    {
        SceneManager.LoadScene("Score");
    }
    public void MenuSelect()
    {
        SceneManager.LoadScene("Main");
    }
}
