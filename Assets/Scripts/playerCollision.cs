using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Obstacle")
            {
                print("Add Score!");
            }
            else
            {
                print("Dead!");
            }
        }

    }
}
