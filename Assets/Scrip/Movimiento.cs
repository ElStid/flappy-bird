using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movimiento : MonoBehaviour
{
    public float velocity;
    private Rigidbody2D dragon;

    public perder control;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        control.perdiste();
    }
}
