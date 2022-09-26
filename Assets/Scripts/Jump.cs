using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump = 1f;
    private bool _jumpPressed = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _jumpPressed = true;
        }   
    }

    private void FixedUpdate()
    {
        if (_jumpPressed == true)
        {
            rb.AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
            _jumpPressed = false;
        }
    }
}
