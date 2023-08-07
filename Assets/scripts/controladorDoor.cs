using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorDoor : MonoBehaviour
{
    public Opendoor objetoOpen;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("openDoor", objetoOpen.opendoor);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player"))
        {
            objetoOpen.ubicadoPuerta = true;
        }
        
     }

     private void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("Player"))
        {
            objetoOpen.ubicadoPuerta = false;
        }
     }
}
