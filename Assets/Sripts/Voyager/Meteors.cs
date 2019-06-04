using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteors : MonoBehaviour {
    /*public Transform start;
    public Transform end;

    private float startTime;

    private float journeyLength;*/
    
  


    // Use this for initialization
    void Start () {
        /*journeyLength = Vector3.Distance(start.position, end.position);
        startTime = Time.time * 2f;*/
        
        

    }
	
	// Update is called once per frame
	void Update () {
        /*float distCovered = (Time.time - startTime) * 10f;
        float fracJourney = distCovered / journeyLength;*/

        transform.position += -Vector3.forward * 10f * Time.deltaTime;
        //transform.position = Vector3.Lerp(start.position, end.position, Time.time * 0.1f);
        //transform.position = Vector3.Lerp(start.position, end.position, fracJourney);
        
    }
}
