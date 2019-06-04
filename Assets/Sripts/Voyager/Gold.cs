using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour {

    public GameObject goldFX;

    ScoreBoard scoreBoard;
    [SerializeField] int scorePerHit = 1;

    private void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    public void OnTriggerEnter(Collider collider)
    {
        scoreBoard.ScoreHit(scorePerHit);
        Instantiate(goldFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
