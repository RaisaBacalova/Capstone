﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

   /* // Use this for initialization
    void Start () {
        Invoke("LoadScene", 5f);
	}
	
	void LoadScene()
    {
        SceneManager.LoadScene(1);
    }*/
}