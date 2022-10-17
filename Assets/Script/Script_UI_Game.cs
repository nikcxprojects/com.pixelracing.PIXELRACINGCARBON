using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Script_UI_Game : MonoBehaviour, IPointerDownHandler, IPointerUpHandler //добавлены события нажатия отжатия
{
    public bool Button_SetActive = false;

    public void OnPointerDown(PointerEventData eventData) //если нажата кнопка
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 0.2f);
        Button_SetActive = true;
    }

    public void OnPointerUp(PointerEventData eventData) //если отпущена
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 0.2f);
        Button_SetActive = false;
    }
}
