using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSuelo : MonoBehaviour
{
    public PersonajeController player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("colision");
        if (collision.gameObject.CompareTag("Suelo") || collision.gameObject.CompareTag("PlataformaC") || collision.gameObject.CompareTag("PlataformaM"))
        {
            //Debug.Log("Toco suelo");
            player.enElsuelo = true;
        }

        if (collision.gameObject.CompareTag("PlataformaM"))
        {
            player.transform.parent = collision.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlataformaM"))
        {
            player.transform.parent = null;
        }
    }
}
