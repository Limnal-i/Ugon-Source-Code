using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{
    // Variables

    scoreKeeper scoreScript;
    gameManager gameManager;

    // ---------------------------------------------------------------------------------

    private void Start()
    {
        scoreScript = GameObject.FindAnyObjectByType<scoreKeeper>();
        gameManager = GameObject.FindAnyObjectByType<gameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Obstacle")
            {
                scoreScript.addToScore(gameManager.scoreMulti);
            }
            else
            {
                SceneManager.LoadScene("GameOver");
            }
        }

    }
}
