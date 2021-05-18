using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class L_puntage : MonoBehaviour
{
    public static int puntaje;
    void Start()
    {
        puntaje = 0;
    }

    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = puntaje.ToString();
    }
}
