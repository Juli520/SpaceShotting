using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp2 : MonoBehaviour
{
    public float multiplier;
    public float duration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            PickUp(collision);
        }
    }

    void PickUp(Collider2D player)
    {
        PlayerController quick = player.GetComponent<PlayerController>();

        quick.ApplyPowerUp2(duration, multiplier);

        Destroy(gameObject);
    }
}
