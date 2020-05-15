using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [Header("Vida")]
    public float life = 50;

    [Header("Movimiento")]
    public float enemySpeed = 3f;
    public float stopDistance = 5f;
    public float retreatDistance;
    private Rigidbody2D rb;
    private Vector2 movement;
    public Transform player;

    [Header("Ataque")]
    public int enemyType;
    public GameObject explosion;
    public GameObject bullet;
    public Transform shootspawn;
    public float fireRate;
    private float nextFire;
    public Transform shootspawn2;

    public LevelManager manager;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").transform;
        GameObject tempManager = GameObject.Find("Level Manager");
        manager = tempManager.GetComponent<LevelManager>();
    }

    void Update()
    {
        Vector3 direction= new Vector3();

        if (player != null)
            direction = player.transform.position - transform.position;
        else
            return;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 180f;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

        if (enemyType == 2 || enemyType == 3)
        {
            if (Vector2.Distance(transform.position, player.position) > stopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, enemySpeed * Time.deltaTime);
            }
            else if (Vector2.Distance(transform.position, player.position) > stopDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
            {
                transform.position = this.transform.position;
            }
            else if(Vector2.Distance(transform.position, player.position) < retreatDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, -enemySpeed * Time.deltaTime);
            }
            if (enemyType == 2)
            {
                if (Time.time > nextFire)
                {
                    nextFire = Time.time + fireRate;
                    Instantiate(bullet, shootspawn.position, shootspawn.rotation);
                }
            }
            if (enemySpeed == 3)
            {
                if (Time.time > nextFire)
                {
                    nextFire = Time.time + fireRate;
                    Instantiate(bullet, shootspawn.position, shootspawn.rotation);
                    Instantiate(bullet, shootspawn2.position, shootspawn2.rotation);
                }
            }
        }

        if (Vector2.Distance(transform.position, player.transform.position) <= stopDistance && (enemyType == 1))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else if (Vector2.Distance(transform.position, player.transform.position) >= stopDistance && (enemyType == 1))
        {
            transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, 1), player.transform.position, enemySpeed * Time.deltaTime);
        }

        if (enemyType == 4)
        {
            transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, 1), player.transform.position, enemySpeed * Time.deltaTime);
        }

        if (enemyType == 5)
        {

        }
    }
    
    public void TakeDamage(float damage)
    {
        life -= damage;
        if (life <= 0)
        {
            SetTypeOfDead();
        }
    }

    public void SetTypeOfDead()
    {
        if (enemyType == 1)
        {
            Instantiate(explosion);
            Destroy(gameObject);
        }
        else if (enemyType != 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        manager.enemyKill++;
    }
}
