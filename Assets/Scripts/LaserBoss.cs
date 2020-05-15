using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBoss : MonoBehaviour
{
    public float damage;
    public Rigidbody2D rb;
    public float speed;

    private void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10 || collision.gameObject.layer == 12)
        {
            if (collision.gameObject.layer == 12)
            {
                PlayerController player = collision.gameObject.GetComponent<PlayerController>();
                player.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
