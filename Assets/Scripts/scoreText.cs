using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreText : MonoBehaviour
{
    // Variables

    scoreKeeper scoreScript;
    private TMP_Text scoreDisplay;

    // ---------------------------------------------------------------------------

    void Update()
    {
        scoreScript = GameObject.FindAnyObjectByType<scoreKeeper>();
        scoreDisplay = GetComponent<TMP_Text>();

        if (SceneManager.GetActiveScene().name == "Game")
        {
            scoreDisplay.text = "Score: " + scoreScript.getScore();
        }
        else if (SceneManager.GetActiveScene().name == "GameOver")
        {
            scoreDisplay.text = Convert.ToString(scoreScript.getScore());
        }
    }
}
