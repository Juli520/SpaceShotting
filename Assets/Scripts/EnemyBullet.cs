using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;


    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        if (hitInfo.gameObject.layer == 12 || hitInfo.gameObject.layer == 10)
        {
            if (hitInfo.gameObject.layer == 12)
            {
                PlayerController player = hitInfo.gameObject.GetComponent<PlayerController>();
                player.TakeDamage(damage);
            }
            Destroy(gameObject);
        }

    }
}
