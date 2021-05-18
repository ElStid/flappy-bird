using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perder : MonoBehaviour
{
    public GameObject Canvasperdiste;
    private void Start()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        
    }
    public void perdiste()
    {
        Canvasperdiste.SetActive(true);
        Time.timeScale = 0;
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }
}
