using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlNivel1 : MonoBehaviour {

    // Use this for initialization
    public void Cambiarescena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
