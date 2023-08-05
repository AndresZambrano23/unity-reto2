using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovY1 : MonoBehaviour
{
    public float minY;
    public float maxY;
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
            lugarObjetivo.transform.position = new Vector2(transform.position.x, minY);
            //transform.localScale = new Vector3(1,-1,1);
            return;
        }
        
        if(lugarObjetivo.transform.position.y == minY){
            lugarObjetivo.transform.position = new Vector2(transform.position.x,maxY);
            //transform.localScale = new Vector3(1,1,1);            
        }

        else if(lugarObjetivo.transform.position.y == maxY){
            lugarObjetivo.transform.position = new Vector2(transform.position.x, minY);
            //transform.localScale = new Vector3(1,-1,1);            
        }
    } 

    private IEnumerator Patrullar()
    {
        while(Vector2.Distance(lugarObjetivo.transform.position, transform.position) > 0.05f){
            Vector2 direction = lugarObjetivo.transform.position - transform.position;
            float yDirection = direction.y;
            
            transform.Translate(direction.normalized * Velocidad * Time.deltaTime);

            yield return null;
        }

        //Debug.Log("Se alcanzo el Objetivo");
        transform.position = new Vector2(transform.position.x, lugarObjetivo.transform.position.y);

        //Debug.Log("Esperando " + TiempoEspera + " Segundos");
        yield return new WaitForSeconds(TiempoEspera);

        //Debug.Log("Se espera lo que necesario para que termine y vuelva a empezar movimiento");
        UpdateObjetivo();
        StartCoroutine("Patrullar");

    }
}
