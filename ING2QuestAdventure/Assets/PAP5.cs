﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAP5 : MonoBehaviour {

    // Use this for initialization
    GameObject[] toEnable, toDisable, Cierto, Falso;
    public GameObject correctSign, incorrectSign, I5;
    public bool acerto;
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
    {
        if (other.tag == "Player")
        {
            foreach (GameObject element in toEnable)
            {
                I5.gameObject.SetActive(true);
                Debug.Log("Se confirma activacion de triger info");
            }

        }
        else if (other.tag == "Info")
        {

            Debug.Log("Se confirma activacion de triger 2");
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

