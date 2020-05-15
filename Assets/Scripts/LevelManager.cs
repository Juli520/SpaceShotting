using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public PlayerController Myplayer;
    
    [Header ("Tiempo")]
    public float maxTime;
    public float currentTime;
    public int wave;
    [Header("Enemigos")]
    public GameObject crab;
    public GameObject octo;
    public GameObject jumper;
    public GameObject wall;
    public GameObject escape;
    private float randX;
    private float randY;
    public int maxEnemies;
    public int counterEnemy;
    public int enemyKill;
    public float timeSpawn;
    public float maxTimeSpawn =5;
    [Header("Disparo")]
    public float spawnRate = 2f;
    public float nextSpawn = 0.0f;

    public PlayerController player;

    private void Awake()
    {
        maxTime = 30f;
    }

    private void Start()
    {
        timeSpawn = maxTimeSpawn;
        counterEnemy = 0;
        SpawnWave();
        currentTime = maxTime;
    }

    void Update()
    {
        if (wave == 11)
        {
            SceneManager.LoadScene("You Win");
        }

        else
        {
            currentTime = currentTime - Time.deltaTime;
            if (currentTime <= 0)
            {
                Destroy(Myplayer.gameObject);
                SceneManager.LoadScene("Game Over");
            }
            NextWave();
        }

    }


    void SpawnWave()
    {
        wave++;
        switch (wave)
        {
            case 1:
                for (int i = 0; i < 3; i++)
                {
                    maxEnemies = 3;
                    randX = Random.Range(-8.4f, 8.2f);
                    randY = Random.Range(-4.5f, 4.5f);
                    float randomEnemy = Random.Range(1, 5);
                    if (randomEnemy == 1)
                    {
                        Instantiate(jumper, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 2)
                    {
                        Instantiate(crab, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 3)
                    {
                        Instantiate(octo, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 4)
                    {
                        Instantiate(wall, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                }
                break;

            case 2:
                for (int i = 0; i < 4; i++)
                {
                    player.life = 250;
                    currentTime = maxTime;
                    enemyKill = 0;
                    maxEnemies = 4;
                    randX = Random.Range(-8.4f, 8.2f);
                    randY = Random.Range(-4.5f, 4.5f);
                    float randomEnemy = Random.Range(1, 5);
                    if (randomEnemy == 1)
                    {
                        Instantiate(jumper, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 2)
                    {
                        Instantiate(crab, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 3)
                    {
                        Instantiate(octo, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 4)
                    {
                        Instantiate(wall, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                }
                break;

            case 3:
                for (int i = 0; i < 5; i++)
                {
                    player.life = 250;
                    currentTime = maxTime;
                    enemyKill = 0;
                    maxEnemies = 5;
                    randX = Random.Range(-8.4f, 8.2f);
                    randY = Random.Range(-4.5f, 4.5f);
                    float randomEnemy = Random.Range(1, 5);
                    if (randomEnemy == 1)
                    {
                        Instantiate(jumper, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 2)
                    {
                        Instantiate(crab, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 3)
                    {
                        Instantiate(octo, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 4)
                    {
                        Instantiate(wall, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (i == 4)
                    {
                        Instantiate(escape, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                }
                break;

            case 4:
                for (int i = 0; i < 6; i++)
                {
                    player.life = 250;
                    currentTime = maxTime;
                    enemyKill = 0;
                    maxEnemies = 6;
                    randX = Random.Range(-8.4f, 8.2f);
                    randY = Random.Range(-4.5f, 4.5f);
                    float randomEnemy = Random.Range(1, 5);
                    if (randomEnemy == 1)
                    {
                        Instantiate(jumper, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 2)
                    {
                        Instantiate(crab, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 3)
                    {
                        Instantiate(octo, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 4)
                    {
                        Instantiate(wall, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                }
                break;

            case 5:
                for (int i = 0; i < 7; i++)
                {
                    player.life = 250;
                    currentTime = maxTime;
                    enemyKill = 0;
                    maxEnemies = 7;
                    randX = Random.Range(-8.4f, 8.2f);
                    randY = Random.Range(-4.5f, 4.5f);
                    float randomEnemy = Random.Range(1, 5);
                    if (randomEnemy == 1)
                    {
                        Instantiate(jumper, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 2)
                    {
                        Instantiate(crab, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 3)
                    {
                        Instantiate(octo, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 4)
                    {
                        Instantiate(wall, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                }
                break;

            case 6:
                for (int i = 0; i < 8; i++)
                {
                    player.life = 250;
                    currentTime = maxTime;
                    enemyKill = 0;
                    maxEnemies = 8;
                    randX = Random.Range(-8.4f, 8.2f);
                    randY = Random.Range(-4.5f, 4.5f);
                    float randomEnemy = Random.Range(1, 5);
                    if (randomEnemy == 1)
                    {
                        Instantiate(jumper, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 2)
                    {
                        Instantiate(crab, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 3)
                    {
                        Instantiate(octo, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (randomEnemy == 4)
                    {
                        Instantiate(wall, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (i == 7)
                    {
                        Instantiate(escape, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                }
                break;

            case 7:
                for (int i = 0; i < 9; i++)
                {
                    player.life = 250;
                    currentTime = maxTime;
                    enemyKill = 0;
                    maxEnemies = 9;
                    randX = Random.Range(-8.4f, 8.2f);
                    randY = Random.Range(-4.5f, 4.5f);
                    float randomEnemy = Random.Range(1, 5);
                    if (randomEnemy == 1)
                    {
                        Instantiate(jumper, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                    if (randomEnemy == 2)
                    {
                        Instantiate(crab, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                    if (randomEnemy == 3)
                    {
                        Instantiate(octo, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                    if (randomEnemy == 4)
                    {
                        Instantiate(wall, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                }
                break;

            case 8:
                for (int i = 0; i < 10; i++)
                {
                    player.life = 250;
                    currentTime = maxTime;
                    enemyKill = 0;
                    maxEnemies = 10;
                    randX = Random.Range(-8.4f, 8.2f);
                    randY = Random.Range(-4.5f, 4.5f);
                    float randomEnemy = Random.Range(1, 5);
                    if (randomEnemy == 1)
                    {
                        Instantiate(jumper, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                    if (randomEnemy == 2)
                    {
                        Instantiate(crab, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                    if (randomEnemy == 3)
                    {
                        Instantiate(octo, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                    if (randomEnemy == 4)
                    {
                        Instantiate(wall, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                    if (i == 9)
                    {
                        Instantiate(escape, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                }
                break;

            case 9:
                for (int i = 0; i < 11; i++)
                {
                    player.life = 250;
                    currentTime = maxTime;
                    enemyKill = 0;
                    maxEnemies = 11;
                    randX = Random.Range(-8.4f, 8.2f);
                    randY = Random.Range(-4.5f, 4.5f);
                    float randomEnemy = Random.Range(1, 5);
                    if (randomEnemy == 1)
                    {
                        Instantiate(jumper, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                    if (randomEnemy == 2)
                    {
                        Instantiate(crab, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                    if (randomEnemy == 3)
                    {
                        Instantiate(octo, new Vector3(randX, randY, 1), Quaternion.identity);
                    }
                    if (randomEnemy == 4)
                    {
                        Instantiate(wall, new Vector3(randX, randY, 1), Quaternion.identity);
                        counterEnemy++;
                    }
                }
                break;

            case 10:
                player.life = 250;
                SceneManager.LoadScene(6);
                break;
        }
    }
    void NextWave()
    {
        if (enemyKill >= maxEnemies)
        {
            SpawnWave();
        }
    }

}
