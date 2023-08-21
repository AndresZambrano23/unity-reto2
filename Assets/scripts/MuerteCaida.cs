using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteCaida : MonoBehaviour
{
    private Vida vida;
    //public float cantidadDano;
    // Start is called before the first frame update
    void Start()
    {
        vida = GetComponent<Vida>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1.63)
        {
            vida.TomarVida(vida.maximoVida);
        }
    }
}


