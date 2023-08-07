using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCabeza : MonoBehaviour
{
    public Vida vida;
    public GameObject door;
    private int intentos = 3;
    private int count = 0;
    private Animator animator;

    void Start() {
      animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
      Debug.Log("cabeza");
      if(other.CompareTag("Pies"))
      {   
          if (intentos == count) {
            AudioManager.Instance.PlaySFX("aplastar");
            Destroy(gameObject);
            vida.efectoRebote(new Vector2(transform.position.x,transform.position.y), transform.localScale.x);
            door.SetActive(true);
          } else {
            count++;
            animator.SetTrigger("GolpeEnemy");
          }
          
      }
    }
}
