using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curar : MonoBehaviour
{
  public float cantidadCurar;
  public Vida vida;

  private void OnTriggerEnter2D(Collider2D other){
    if(other.CompareTag("Player"))
    {
        vida.Curar(cantidadCurar);
        AudioManager.Instance.PlaySFX("curar");
        Destroy(gameObject);
    }
  }
}
