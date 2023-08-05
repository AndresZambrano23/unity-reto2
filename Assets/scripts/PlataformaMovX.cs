using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovX : MonoBehaviour
{
   public float minX;
    public float maxX;
    public float TiempoEspera = 2f;
    public float Velocidad = 1f;

    private GameObject lugarObjetivo;

    // Start is called before the first frame update
    void Start()
    {
        UpdateObjetivo();
        StartCoroutine("Patrullar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateObjetivo(){
        if(lugarObjetivo == null){
            lugarObjetivo = new GameObject("Sitio_objetivo");
            lugarObjetivo.transform.position = new Vector2(minX, transform.position.y);
            //transform.localScale = new Vector3(-1,1,1);
            return;
        }
        
        if(lugarObjetivo.transform.position.x == minX){
            lugarObjetivo.transform.position = new Vector2(maxX, transform.position.y);
            //transform.localScale = new Vector3(1,1,1);            
        }

        else if(lugarObjetivo.transform.position.x == maxX){
            lugarObjetivo.transform.position = new Vector2(minX, transform.position.y);
            //transform.localScale = new Vector3(-1,1,1);            
        }
    } 

    private IEnumerator Patrullar()
    {
        while(Vector2.Distance(transform.position, lugarObjetivo.transform.position) > 0.05f){
            Vector2 direction = lugarObjetivo.transform.position - transform.position;
            float xDirection = direction.x;
            
            transform.Translate(direction.normalized * Velocidad * Time.deltaTime);

            yield return null;
        }

        //Debug.Log("Se alcanzo el Objetivo");
        transform.position = new Vector2(lugarObjetivo.transform.position.x, transform.position.y);

        //Debug.Log("Esperando " + TiempoEspera + " Segundos");
        yield return new WaitForSeconds(TiempoEspera);

        //Debug.Log("Se espera lo que necesario para que termine y vuelva a empezar movimiento");
        UpdateObjetivo();
        StartCoroutine("Patrullar");

    }
}
