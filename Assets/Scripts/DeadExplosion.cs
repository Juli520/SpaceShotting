using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadExplosion : MonoBehaviour
{
    public float damage = 50;
    public LevelManager manager;

    private void Start()
    {
        GameObject tempManager = GameObject.Find("Level Manager");
        manager = tempManager.GetComponent<LevelManager>();
        Invoke("DestroyExplosion", 0.5f);
    }
    private void DestroyExplosion()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.TakeDamage(damage);
        }
    }
}
