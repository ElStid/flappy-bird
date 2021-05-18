using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_obstaculo : MonoBehaviour
{
    public float velocidad;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * velocidad * Time.deltaTime;
    }
}
