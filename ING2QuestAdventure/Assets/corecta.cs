using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corecta : MonoBehaviour {
    GameObject[] toEnable, toDisable;
    public GameObject correctSign, incorrectSign;
    public string name;
    // Use this for initialization
    void Start () {
        toEnable = GameObject.FindGameObjectsWithTag("ToEnable");
        toDisable = GameObject.FindGameObjectsWithTag("ToDisable");
    }

    // Update is called once per frame
    void RightAnswer(string name)
    {
        // Disabling game objects that are no longer needed
        
        if (name == "Correcto")
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
}
