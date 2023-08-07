using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour
{
  public bool opendoor = false;
  public bool ubicadoPuerta = false;  
  public Puntaje puntaje;
  public GameObject panelPuntaje; 
  public GameObject panelWinner;
  private float puntos; 
  // Start is called before the first frame update
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {        
    if (Input.GetKey(KeyCode.B) && ubicadoPuerta == true)
      {
        opendoor = !opendoor;
        puntos = puntaje.ObtenerPuntaje();
        if (opendoor && puntos == 0) {
          panelPuntaje.SetActive(true);
        }
        if (opendoor && puntos > 0) {
          panelPuntaje.SetActive(false);
          AudioManager.Instance.musicSource.Stop();
          AudioManager.Instance.PlaySFX("winner");
          panelWinner.SetActive(true);
        }
      }
  }
}
