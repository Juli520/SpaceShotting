using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    [Header("Vida")]
    public float life;
    [Header("Ataque")]
    public GameObject laser;
    public GameObject shootSpawn;
    public float fireRate;
    public float nextFire;
    public float rotation;

    public Rigidbody2D rb;
    public GameObject player;

    private void Start()
    { 
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        if (player != null)
        {
            Vector3 vectorToTarget = player.transform.position - shootSpawn.transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            shootSpawn.transform.rotation = Quaternion.Slerp(shootSpawn.transform.rotation, q, Time.deltaTime * rotation);
        }
        else
            return;

        if (nextFire <= 0)
        {
            Instantiate(laser, shootSpawn.transform.position, shootSpawn.transform.rotation);

            nextFire = fireRate;
        }
        else
            nextFire -= Time.deltaTime;
    }

    public void TakeDamage(float damage)
    {
        life -= damage;
        if (life <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("You Win");
        }
    }
}
