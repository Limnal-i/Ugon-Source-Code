using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o_Move : MonoBehaviour
{
    // Variables 

    public float objectSpeed;

    Rigidbody2D rb;
    BoxCollider2D bc;

    float screenEdgeLeft;
    float objectWidth;

    // ---------------------------------------------------------------------------------

    // Allow Script to access needed components. Save Camera bounds on X axis.
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();

        objectWidth = bc.size.x;

        screenEdgeLeft = Camera.main.ScreenToWorldPoint(Vector3.zero).x - objectWidth;
    }

    // Add force to obstacle object. If beyond left camera bounds destroy self.
    private void FixedUpdate()
    {
        rb.AddForce(Vector2.left * objectSpeed);
        if (transform.position.x < screenEdgeLeft)
        {
            Destroy(gameObject);
        }
    }
}
