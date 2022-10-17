using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Script_Player : MonoBehaviour
{
    public static float Score;
    public Text ScoreTxt;
    public Sprite Car1;
    public Sprite Car2;
    public Sprite Car3;
    public float stateLine;
    public AudioSource sound;

    void Start()
    {
        stateLine = 1f;
        Score = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTxt.text = "DISTANCE:" + Convert.ToInt32(Score);

        PlayerPrefs.SetFloat("Nowscore", Score);
        if (SelectCar.SelectedCar == 0f)
        {
            GetComponent<SpriteRenderer>().sprite = Car1;
        }
        if (SelectCar.SelectedCar == 1f)
        {
            GetComponent<SpriteRenderer>().sprite = Car2;
        }
        if (SelectCar.SelectedCar == 2f)
        {
            GetComponent<SpriteRenderer>().sprite = Car3;
        }
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "Ground")
        {
            if (Score > PlayerPrefs.GetFloat("score"))
            {

            PlayerPrefs.SetFloat("score", Score);
            }


            SceneManager.LoadScene("Main");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Score++;
            Destroy(collision.gameObject);
        }
    }
    public void OnLeft()
    {
        if (stateLine > 0)
        {
            stateLine--;
            transform.Translate(-0.76f, 0f, 0f);
            sound.Play(); 
        }
    }
    public void OnRight()
    {
        if (stateLine < 3)
        {
            stateLine++;
            transform.Translate(0.76f, 0f, 0f);
            sound.Play();

        }
    }
}