using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarLife : MonoBehaviour
{
    private Transform bar;
    public GameObject player;


    private void Awake()
    {
        bar = transform.Find("Bar");
    }

    public void SetSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

    private void Update()
    {
        if (player != null)
        {
            transform.position = player.transform.position + new Vector3(0, .5f, 0);
        }
    }
}
