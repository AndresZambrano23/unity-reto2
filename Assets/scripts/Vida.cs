using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float vida;
    public float maximoVida;
    public BarraVida barraVida;
    public GameObject gameOver;
    public float tiempoPerdidaControl;
    private PersonajeController player;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        vida = maximoVida;
        player = GetComponent<PersonajeController>();
        animator = GetComponent<Animator>();
        barraVida.InicializarBarraDeVida(vida);
    }



    public void TomarVida(float dano)
    {
        vida = vida - dano;
        barraVida.CambiarVidaActual(vida);
        Debug.Log("vida: " + vida);
        if (vida <= 0)
        {
            //Destroy(gameObject);
            gameOver.SetActive(true);
        }
    }

    public void efectoDano(Vector2 posicion, float direccion)
    {
        StartCoroutine(PerderControl());
        animator.SetTrigger("Golpe");
        player.Rebote(posicion, direccion);
    }

    private IEnumerator PerderControl()
    {
        player.sePuedeMover = false;
        yield return new WaitForSeconds(tiempoPerdidaControl);
        player.sePuedeMover = true;

    }

    public void Curar(float curacion)
    {
        if ((vida + curacion) > maximoVida)
        {
            vida = maximoVida;

        }
        else
        {
            vida = vida + curacion;
        }
        barraVida.CambiarVidaActual(vida);
    }
}
