using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLines : MonoBehaviour
{
    public GameObject[] Lines;
    public GameObject Line;
    public Transform SpawnPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Lines = GameObject.FindGameObjectsWithTag("Line");

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Line")
        {
            if (Lines.Length < 3f)
            {
                Instantiate(Line, SpawnPosition.position, transform.rotation);
            }
        }
    }
}
