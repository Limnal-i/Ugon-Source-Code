using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o_Move : MonoBehaviour
{
    [SerializeField] float objectSpeed;
    Rigidbody2D rb;
    BoxCollider2D bc;

    float screenEdgeLeft;
    float objectWidth;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();

        objectWidth = bc.size.x;

        screenEdgeLeft = Camera.main.ScreenToWorldPoint(Vector3.zero).x - objectWidth;
    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector2.left * objectSpeed);
        if (transform.position.x < screenEdgeLeft)
        {
            Destroy(gameObject);
        }
    }
}
