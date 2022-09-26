using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float HorizontalInput;
    public float speed = 1f;
    private void Awake()
    {
        _rb = GetComponent <Rigidbody2D>();
    }

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        //transform.position += Vector3.right * HorizontalInput * speed * Time.deltaTime;
        //transform.Translate( Vector3.right * HorizontalInput * speed * Time.deltaTime);

        _rb.velocity = new Vector2(speed * HorizontalInput, _rb.velocity.y);
        
        //_rb.AddForce(new Vector2(HorizontalInput * speed, transform.position.y), ForceMode2D.Force);
    }
}
