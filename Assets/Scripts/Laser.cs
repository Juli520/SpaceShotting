using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float currentTime;
    bool laserOn = false;
    public float maxTimeOn;
    public GameObject laser;
    public float maxTimeOff;
    public float damage = 20;

    void Start()
    {
        currentTime = maxTimeOff;
        maxTimeOn = 1.5f;
        maxTimeOff = 5f;
    }

    void Update()
    {
        currentTime = currentTime - Time.deltaTime;

        if (currentTime <= 0 && laserOn == false)
        {
            laserOn = !laserOn;
            currentTime = maxTimeOn;
            if(laser != null)
                laser.SetActive(laserOn);
        }

        if (currentTime <= 0 && laserOn == true)
        {
            laserOn = !laserOn;
            currentTime = maxTimeOff;
            if (laser != null)
                laser.SetActive(laserOn);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        if (hitInfo.gameObject.layer == 12 || hitInfo.gameObject.layer == 9)
        {
            if (hitInfo.gameObject.layer == 12)
            {
                PlayerController player = hitInfo.gameObject.GetComponent<PlayerController>();
                player.TakeDamage(damage);

            }
            if (hitInfo.gameObject.layer == 9)
            {
                Enemies enemies = hitInfo.gameObject.GetComponent<Enemies>();
                enemies.TakeDamage(damage);
            }
        }

    }
}
