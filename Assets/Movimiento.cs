using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocity;
    private Rigidbody2D dragon;
    void Start()
    {
        dragon = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragon.velocity = Vector2.up * velocity;
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        
    }
}
