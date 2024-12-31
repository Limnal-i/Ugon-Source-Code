using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    scoreKeeper scoreScript;

    private void Start()
    {
        scoreScript = GameObject.FindAnyObjectByType<scoreKeeper>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Obstacle")
            {
                scoreScript.addToScore();
            }
            else
            {
                print("Dead!");
            }
        }

    }
}
