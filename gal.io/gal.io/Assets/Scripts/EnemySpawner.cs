using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2.0f;
    public float spawnRadius = 10.0f;
    public float minDistanceFromPlayer = 1.0f;
    public GameObject player;

    private float timeSinceLastSpawn = 0.0f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0.0f;
        }
    }

    void SpawnEnemy()
    {
        Vector2 spawnPos = Random.insideUnitCircle * spawnRadius;
        float distanceFromPlayer = Vector2.Distance(spawnPos, player.transform.position);

        if (distanceFromPlayer >= minDistanceFromPlayer)
        {
            GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
            enemy.AddComponent<Enemy>().player = player;
        }
        else
        {
            // Try spawning the enemy again
            SpawnEnemy();
        }
    }
}

public class Enemy : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject player;

    void Update()
    {
        // Find the direction from the enemy to the player
        Vector2 direction = player.transform.position - transform.position;

        // Normalize the direction so that the enemy moves at a constant speed
        direction.Normalize();

        // Move the enemy towards the player
        transform.position += (Vector3)direction * speed * Time.deltaTime;
    }
}
