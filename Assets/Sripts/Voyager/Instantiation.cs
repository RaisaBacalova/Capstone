using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour {

    public GameObject meteorToCreate;
    float spacing = 1000f;

    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < 50; i++)
        {

            Object.Instantiate(meteorToCreate, new Vector3(i, i, i), Quaternion.identity);
            meteorToCreate.transform.localPosition = new Vector3(i + i * spacing, 0, i + i * spacing);
            //GameObject newMeteor = (GameObject)Object.Instantiate(meteorToCreate, new Vector3(i * 2, 0, 0), Quaternion.identity);
            //Transform transform = newMeteor.GetComponent<Transform>();
            // GameObject newMeteor = (GameObject)Object.Instantiate(meteorToCreate, transform.position, transform.rotation);


        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
