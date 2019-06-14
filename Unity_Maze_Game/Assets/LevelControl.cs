using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour {

	// Use this for initialization
 

    private void OnTriggerEnter2D(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
           // SceneManager.LoadScene(1);
            SceneManager.LoadScene("Level1");
        }
    }
}
