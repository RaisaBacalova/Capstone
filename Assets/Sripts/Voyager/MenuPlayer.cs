using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPlayer : MonoBehaviour {

    bool isControlEnabled = true;
    
  


    private void Update()
    {
        if (isControlEnabled)
        {
            ProcessTranslation();  
        }
    
    }

    private void ProcessTranslation()
    {
        transform.position += Vector3.forward * 10 * Time.deltaTime;
        transform.Translate(Input.acceleration.x * 2, 0, -Input.acceleration.z * 2);
        
    }

    void OnPlayerDeath()
    {
        print("Controls frozen");
        isControlEnabled = false;
        
    }

 

}
