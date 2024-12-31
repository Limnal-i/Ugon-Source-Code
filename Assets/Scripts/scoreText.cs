using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreText : MonoBehaviour
{
    scoreKeeper scoreScript;
    Text scoreDisplay;
    private void Start()
    {
        scoreScript = GameObject.FindAnyObjectByType<scoreKeeper>();
        scoreDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            scoreDisplay.text = "Score: " + scoreScript.getScore();
        }
        else
        {
            scoreDisplay.text = Convert.ToString(scoreScript.getScore());
        }
    }
}
