﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    public float shootRate = 0.2f;

    private float shootTimer = 0f;


    // To shoot a projectile from the player
    void Shoot()
    {
        GameObject clone = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
        rigid.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse); 
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer += Time.deltaTime;
        if (shootTimer > shootRate)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Shoot();
                shootTimer = 0f;
            }
        }
    }
}
