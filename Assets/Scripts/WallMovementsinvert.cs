using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovementsinvert : MonoBehaviour
{
    public float speedWall = 3f;
    public int directionY = -1;
    public int directionX = 1;

    void Update()
    {
        transform.position += new Vector3(directionX, directionY, 0) * speedWall * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 14)
        {
            directionX = directionX * -1;
            directionY = directionY * -1;
        }
    }
}
