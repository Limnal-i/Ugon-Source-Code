using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreText : MonoBehaviour
{
    scoreKeeper scoreScript;
    private TMP_Text scoreDisplay;
    private void Start()
    {
        scoreScript = GameObject.FindAnyObjectByType<scoreKeeper>();
        scoreDisplay = GetComponent<TMP_Text>();
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
