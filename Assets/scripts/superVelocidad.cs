using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superVelocidad : MonoBehaviour
{
    public float tiempoPoder = 5f;
    public float velMovement = 10f;
    public PersonajeController player;

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player"))
        {            
            AudioManager.Instance.PlaySFX("habilidad");
            player.superVelocidad(velMovement,tiempoPoder);
            //Destroy(gameObject);
            gameObject.SetActive(false);

        }
    }
}
