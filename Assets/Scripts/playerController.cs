using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Variables

    public float forceApplied;

    Rigidbody2D rb;

    // ---------------------------------------------------------------------------

    // Enable script to access Ridgidbody component
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Detect input and add velocity to player object. Play sound effect.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Game Events/Player_Move");
            rb.velocity = (Vector2.up * forceApplied);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Game Events/Player_Move");
            rb.velocity = (Vector2.down * forceApplied);
        }
    }
}
