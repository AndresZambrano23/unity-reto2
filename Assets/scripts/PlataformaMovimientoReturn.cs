using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovimientoReturn : MonoBehaviour
{
    public float tiempoEspera = 0;
    public float tiempoRecuperacion = 0;
    public float velocidadRotacion = 0;
    private Rigidbody2D rb2D;    
    private bool caida = false;
    private float posicionX;
    private float posicionY;

    // Start is called before the first frame update
    void Start()
    {
        posicionX = transform.position.x;
        posicionY = transform.position.y;
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(caida){
            transform.Rotate(new Vector3(0,0, -velocidadRotacion * Time.deltaTime));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player")){
            StartCoroutine(Caida(collision));
        }
    }

    private IEnumerator Caida(Collision2D other){
        yield return new WaitForSeconds(tiempoEspera);
        caida = true;
        //Physics2D.IgnoreCollision(transform.GetComponent<Collider2D>(), other.transform.GetComponent<Collider2D>());
        rb2D.constraints = RigidbodyConstraints2D.None;
        rb2D.AddForce(new Vector2(0.1f, 0));
        StartCoroutine(recuperar());
    }

    private IEnumerator recuperar(){
        yield return new WaitForSeconds(tiempoRecuperacion);
        Debug.Log("recuperacion");
        gameObject.SetActive(true);
        rb2D.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        gameObject.transform.position = new Vector3(posicionX,posicionY,0);
        transform.eulerAngles = new Vector3(0, 0, 0);
        caida = false;
    }
}
