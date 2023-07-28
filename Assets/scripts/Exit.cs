using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void salir()
    {
        Debug.Log("salir");
        #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
}
