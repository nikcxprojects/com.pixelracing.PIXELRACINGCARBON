using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectCar : MonoBehaviour
{
    public static float NowCar;
    public static float SelectedCar;
    public Sprite Car1;
    public Sprite Car2;
    public Sprite Car3;
   private void Start()
    {
        NowCar = SelectedCar;
    }
    void Update()
    {
        if (NowCar == 0f)
        {
            GetComponent<Image>().sprite = Car1;
        }
        if (NowCar == 1f)
        {
            GetComponent<Image>().sprite = Car2;
        }
        if (NowCar == 2f)
        {
            GetComponent<Image>().sprite = Car3;
        }
    }
    public void Right()
    {
        if (NowCar < 2)
        {
            NowCar += 1;
        }
    }
    public void Left()
    {
        if (NowCar > 0)
        {
            NowCar -= 1;
        }
    }
    public void Select()
    {
        SelectedCar = NowCar;
        SceneManager.LoadScene("Main");
    }
    public void MenuSelect()
    {
        SceneManager.LoadScene("Main");
    }
}
