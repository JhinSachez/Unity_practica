using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float starthealth;
    private float hp;

    public GameObject DiePEffect;
    void Start()
    {
        hp = starthealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (DiePEffect != null)
        {
            Instantiate(DiePEffect, transform.position, quaternion.identity);
        }

        Destroy(gameObject);
    }
}
