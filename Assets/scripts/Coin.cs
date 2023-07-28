using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Moneda");

        gameObject.SetActive(false);
        //Destroy(gameObject);

        string scene = SceneManager.GetActiveScene().name;
        switch (scene)
        {
            case "level1":
                Debug.Log("level2");
                //SceneManager.LoadScene("level2");
                break;

            case "level2":
                Debug.Log("level3");
                break;
        }

    }
}
