using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


public class Shooting : MonoBehaviour
{
    public float shootspeed, shootTimer;
    private bool isShooting;
    public Transform shootingpoint;
    public GameObject bulletPrefab;

    private void Start()
    {
        isShooting = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isShooting)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        int direction()
        {
            if (transform.localScale.x < 0f)
            {
                return -1;
            }
            else
            {
                return +1;
            }
        }
        
        isShooting = true;
        GameObject newBullet = Instantiate(bulletPrefab, shootingpoint.position, quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootspeed * direction() * Time.fixedDeltaTime, 0f);
        newBullet.transform.localScale =
            new Vector2(newBullet.transform.localScale.x * direction(), newBullet.transform.localScale.y);
        yield return new WaitForSeconds(shootTimer);
        isShooting = false;
    }
}
