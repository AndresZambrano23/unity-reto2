using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject pauseMenu;

    public GameObject configurcionMenu;

    private Animator transition;

    public void pausa()
    {
        Debug.Log("pausa");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void continuar()
    {
        Debug.Log("continuar");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void reiniciarNivel()
    {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene);
    }

    public void devolverHome()
    {
        transition = GetComponentInChildren<Animator>();
        StartCoroutine(transitionScena("home"));
    }

    public void configuracion()
    {
        pauseMenu.SetActive(false);
        configurcionMenu.SetActive(true);
    }

    public void regresar()
    {
        pauseMenu.SetActive(true);
        configurcionMenu.SetActive(false);
    }

    private IEnumerator transitionScena(string scena)
    {
        transition.SetTrigger("transition");
        Time.timeScale = 1f;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(scena);
    }

}
