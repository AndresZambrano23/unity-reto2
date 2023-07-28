using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public void jugar()
    {
        Debug.Log("Jugar");
        SceneManager.LoadScene("Nivel_1");
    }

    public void salir()
    {
        Debug.Log("salir");
        Application.Quit();
    }
}
