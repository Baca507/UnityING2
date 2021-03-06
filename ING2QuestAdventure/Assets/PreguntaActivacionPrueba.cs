﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PreguntaActivacionPrueba : MonoBehaviour {
    GameObject[] toEnable, toDisable, Cierto, Falso;
    public GameObject correctSign, incorrectSign, P1;

    // Use this for initialization
    void Start()
    {
        // Finding game objects with tags "ToEnable" and "ToDisable"
        toEnable = GameObject.FindGameObjectsWithTag("ToEnable");
        toDisable = GameObject.FindGameObjectsWithTag("ToDisable");
        Cierto = GameObject.FindGameObjectsWithTag("Cierto");
        Falso = GameObject.FindGameObjectsWithTag("Falso");

        // Disabling game objects with tag "ToEnable"
        foreach (GameObject element in toEnable)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Cierto)
        {
            element.gameObject.SetActive(false);
        }
        foreach (GameObject element in Falso)
        {
            element.gameObject.SetActive(false);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {   if (other.tag == "Player")
        {
            foreach (GameObject element in toEnable)
            {
                P1.gameObject.SetActive(true);
                Debug.Log("Se confirma activacion de triger info");
            }
            
        }
    }
    void RightAnswer(string resp)
    {
        // Disabling game objects that are no longer needed
        foreach (GameObject element in toDisable)
        {
            element.gameObject.SetActive(false);
        }
        if (resp == "Correcto")
        {
            // Turn on "correct" sign
            correctSign.gameObject.SetActive(true);
            Debug.Log("Respuesta Correcta, ha ganado 5 puntos Pase a la Siguiente Pregunta");
        }
        else
        {
            incorrectSign.gameObject.SetActive(true);
            Debug.Log("Respuesta Incorrecta, ha perdido 5 puntos Pase a la Siguiente Pregunta");
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            foreach (GameObject element in toEnable)
            {   
                element.gameObject.SetActive(false);
                Debug.Log("Se confirma activacion y ha salido de la colision info");
            }
        }
    }
}
