using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour {

    private float levelLoadDelay = 2f;
    //public GameObject winFX;

    private void OnTriggerEnter(Collider collider)
    {
        //Instantiate(winFX, transform.position, Quaternion.identity);
        Invoke("YouWon", levelLoadDelay);
    }

    private void YouWon()
    {
        print("Victory");
        SceneManager.LoadScene(0);
    }
}
