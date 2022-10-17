using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] Objects;
    public GameObject RandBlock;

    public void Start()
    {
        StartCoroutine(Spawn(Random.Range (1f, 10f)));
    }
    IEnumerator Spawn(float seconds)
    {
        yield return new WaitForSeconds(Random.Range(1f, seconds));
        RandBlock = Objects[Random.Range(0, Objects.Length)];
        Instantiate(RandBlock, transform.position, transform.rotation);
        StartCoroutine(Spawn(6f));
    }
}
