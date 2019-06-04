using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

    private float levelLoadDelay = 2f;
    public GameObject deathFX;
    private Gold gold;
   

    private void OnTriggerEnter(Collider collider)
    {
        switch (collider.gameObject.tag)
        {
            case "Finish":
                print("You won");
                break;
            case "Enemy":
                deathFX.SetActive(true);
                StartDeathSequence();
                Invoke("ReloadLevel", levelLoadDelay);
                break;
            case "Gold":
                print("Gold");
                gold.OnTriggerEnter(collider);
                break;
        }
        
}

    private void StartDeathSequence()
{

    SendMessage("OnPlayerDeath");

}

    public void ReloadLevel()
{
    SceneManager.LoadScene(1);
    
}
}
