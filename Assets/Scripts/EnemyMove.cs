using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    public Transform moveEnemy;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    private float wait;
    public float start;
    public float life = 90;
    public GameObject powerUp;
    public GameObject powerUp2;

    private void Start()
    {
        Destroy(gameObject, 30f);
        wait = start;
        moveEnemy = GameObject.Find("Veni").GetComponent<Transform>();
        moveEnemy.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveEnemy.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveEnemy.position) < 0.2f)
        {
            if(wait <= 0)
            {
                moveEnemy.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                wait = start;
            }
            else
            {
                wait -= Time.deltaTime;
            }
        }
    }

    public void TakeDamage(float damage)
    {
        life -= damage;
        if (life <= 0)
        {
            TypeofPower();
            Destroy(gameObject);
        }
    }

    public void TypeofPower()
    {
        int typePU = Random.Range(0, 2);
        if (typePU == 0)
        {
            Instantiate(powerUp, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(powerUp2, transform.position, Quaternion.identity);
        }
    }
}
