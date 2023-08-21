using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteCaida2 : MonoBehaviour
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
        if (transform.position.y < -18)
        {
            vida.TomarVida(vida.maximoVida);
        }
    }
}
