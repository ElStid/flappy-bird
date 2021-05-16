using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muchos_obstaculos : MonoBehaviour
{
    public float tiempoMax = 1;
    private float tiempoIni = 0;
    public GameObject obstaculo;
    public float altura;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        GameObject obstaculo__ = Instantiate(obstaculo);
        obstaculo__.transform.position = transform.position + new Vector3(0,0,0);
        Destroy(gameObject, 200);
        
    }

    void Update()
    {
        if (tiempoIni > tiempoMax)
        {
            GameObject obstaculo__ = Instantiate(obstaculo);
            obstaculo__.transform.position = transform.position + new Vector3(0, Random.Range(-altura,altura), 0);
            Destroy(gameObject , 200);
            
            tiempoIni = 0;
        }
        else
        {
            tiempoIni += Time.deltaTime;       
        }
    }
    
}
