using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletVelocity = 10f;

    void Update()
    {
        // Check if the player has pressed the fire button
        if (Input.GetButtonDown("Fire1"))
        {
            // Spawn a bullet at the bullet spawn point
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            // Set the velocity of the bullet
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletVelocity;
        }
    }
}

