using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScena : MonoBehaviour
{
    public void changeScena(int scena)
    {
        SceneManager.LoadScene(scena);
    }
}
