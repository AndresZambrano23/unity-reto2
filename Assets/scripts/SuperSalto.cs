using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSalto : MonoBehaviour
{
    public float tiempoPoder = 5f;
    public float fuerzaJump = 15f;
    public PersonajeController player;

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player"))
        {
            AudioManager.Instance.PlaySFX("habilidad");
            player.superSalto(fuerzaJump,tiempoPoder);
            Destroy(gameObject);
        }
    }
}
