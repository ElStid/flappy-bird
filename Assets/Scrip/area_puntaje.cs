using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class area_puntaje : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        L_puntage.puntaje++;
    }
}
