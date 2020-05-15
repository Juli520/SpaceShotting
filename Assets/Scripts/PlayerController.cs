using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("Vida")]
    public float life = 200f;

    [Header("Movimiento")]
    public float moveSpeed = 3f;
    private Rigidbody2D rb;
    Vector2 movement;
    public Camera cam;
    Vector2 mousePos;
    
    [Header("Disparo")]
    public GameObject shoot;
    public Transform shootspawn;
    public Transform shootSpawn2;
    public Transform shootSpawn3;
    public Transform shootSpawn4;
    public Transform shootSpawn5;
    public Transform shootSpawn6;
    public float fireRate;
    public float fireRate2;
    private float nextFire;

    [SerializeField]private BarLife healthbar;
    float maxLife;
    float current;
    float auxFire;
    float current2;
    float auxSpeed;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        maxLife = life;
        auxFire = fireRate2;
        auxSpeed = moveSpeed;
    }

    void Update()
    {

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shoot, shootspawn.position, shootspawn.rotation);
        }

        if (Input.GetButton("Fire2") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate2;
            Instantiate(shoot, shootspawn.position, shootspawn.rotation);
            Instantiate(shoot, shootSpawn2.position, shootSpawn2.rotation);
            Instantiate(shoot, shootSpawn3.position, shootSpawn3.rotation);
            Instantiate(shoot, shootSpawn4.position, shootSpawn4.rotation);
            Instantiate(shoot, shootSpawn5.position, shootSpawn5.rotation);
            Instantiate(shoot, shootSpawn6.position, shootSpawn6.rotation);
        }
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        healthbar.SetSize(life/maxLife);

        current = current - Time.deltaTime;
        current2 = current2 - Time.deltaTime;

        if (current <= 0)
        {
            fireRate2 = auxFire;
        }

        if (current2 <= 0)
        {
            moveSpeed = auxSpeed;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 LookDirec = mousePos - rb.position;
        float angle = Mathf.Atan2(LookDirec.y, LookDirec.x) * Mathf.Rad2Deg ;
        rb.rotation = angle;
    }

    public void TakeDamage(float damage)
    {
        life -= damage;
        if (life <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Game Over");
        }
    }

    public void ApplyPowerUp(float duration, float divider)
    {
        if (current <= 0)
        {
            fireRate2 /= divider;
            current = duration;
        }
    }

    public void ApplyPowerUp2(float duration, float multiplier)
    {
        if (current2 <= 0)
        {
            moveSpeed *= multiplier;
            current2 = duration;
        }
    }
}
