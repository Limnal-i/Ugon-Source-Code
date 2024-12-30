using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    gameManager gamemanager;

    private void Start()
    {
        gamemanager = GameObject.FindAnyObjectByType<gameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Obstacle")
            {
                gamemanager.addToScore();
            }
            else
            {
                print("Dead!");
            }
        }

    }
}
