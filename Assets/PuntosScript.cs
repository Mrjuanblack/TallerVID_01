using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class PuntosScript : MonoBehaviour
{
    public GameObject[] referenciasFrutas;
    public GameObject referenciaCanva;

    private int puntaje1 = 0;
    private int puntaje2 = 0;
    private int puntaje3 = 0;
    private int puntaje4 = 0;

    private int puntaje = 0;
    // Start is called before the first frame update
    void Start()
    {
        puntaje1 = Random.Range(20, 70);
        puntaje2 = Random.Range(20, 70);
        puntaje3 = Random.Range(20, 70);
        puntaje4 = Random.Range(-20, -10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Array.Exists(referenciasFrutas, element => element == other.gameObject))
        {
            if(other.gameObject == referenciasFrutas[0])
            {
                puntaje += puntaje1;
            }
            else if(other.gameObject == referenciasFrutas[1])
            {
                puntaje += puntaje2;
            }
            else if(other.gameObject == referenciasFrutas[2])
            {
                puntaje += puntaje3;
            }
            else if(other.gameObject == referenciasFrutas[3])
            {
                puntaje += puntaje4;
            }
            referenciaCanva.GetComponent<TextMeshProUGUI>().text = string.Format("Puntos: {0}", (puntaje));
        }
    }
}
