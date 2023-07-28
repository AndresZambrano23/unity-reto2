using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private Animator transition;

    public GameObject imgBlack;

    public void Start()
    {
        transition = GetComponentInChildren<Animator>();
        Debug.Log("aca llegue");
        if (imgBlack)
        {
            StartCoroutine(sleep());
        }
    }

    public void changeNewScena(string scena)
    {
        StartCoroutine(transitionScena(scena));
    }

    private IEnumerator sleep()
    {
        yield return new WaitForSeconds(3f);
        imgBlack.SetActive(false);
    }

    private IEnumerator transitionScena(string scena)
    {
        transition.SetTrigger("transition");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(scena);
    }
}
