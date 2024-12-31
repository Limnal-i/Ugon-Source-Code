using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        scoreDisplay.text = "Score: " + scoreScript.getScore();
    }
}
