using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAP8 : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {   if (other.tag == "Player")
        {

            Debug.Log("Se confirma activacion");
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Se confirma activacion y esta aun dentro de la colision");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Se confirma activacion y ha salido de la colision");
    }
}
