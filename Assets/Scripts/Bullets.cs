using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 40;
    public Rigidbody2D rb;


    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if (hitInfo.gameObject.layer == 9 || hitInfo.gameObject.layer == 10 || hitInfo.gameObject.layer == 14 || hitInfo.gameObject.layer == 15)
        {
            if (hitInfo.gameObject.layer == 9)
            {
                Enemies enemy = hitInfo.gameObject.GetComponent<Enemies>();
                enemy.TakeDamage(damage);
            }

            if (hitInfo.gameObject.layer == 15)
            {
                EnemyMove escape = hitInfo.gameObject.GetComponent<EnemyMove>();
                escape.TakeDamage(damage);
            }
            
            if (hitInfo.gameObject.layer == 14)
            {
                Boss boss = hitInfo.gameObject.GetComponent<Boss>();
                boss.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
        
    }
}
