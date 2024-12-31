using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreText : MonoBehaviour
{
    gameManager gamemanager;
    Text scoreDisplay;
    private void Start()
    {
        gamemanager = GameObject.FindAnyObjectByType<gameManager>();
        scoreDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = "Score: " + gamemanager.getScore();
    }
}
