using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteCaida3 : MonoBehaviour
{
    private Vida vida;
    void Start()
    {
        vida = GetComponent<Vida>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            vida.TomarVida(vida.maximoVida);
        }
    }
}
