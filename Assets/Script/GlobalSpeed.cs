using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSpeed : MonoBehaviour
{
    public static float Car;
    public static float Speed;
    public GameObject ButStop;
    void Start()
    {
        Speed =1f;
        Car = SelectCar.SelectedCar;
    }
    private void Update()
    {
        if (Car == 0)
        {
            if (Speed < 5)
            {
                Speed += Time.deltaTime;
            }
        }
        if (Car == 1)
        {
            if (Speed < 6)
            {
                Speed += Time.deltaTime;
            }
        }
        if (Car == 2)
        {
            if (Speed < 8)
            {
                Speed += Time.deltaTime;
            }
        }
        if (ButStop.GetComponent<Script_UI_Game>().Button_SetActive == true)
        {
            if (Speed > 1f)
            {
            Speed -= Time.deltaTime * 2f;
            }
        }
        Script_Player.Score += Time.deltaTime * Speed;
    }
}
