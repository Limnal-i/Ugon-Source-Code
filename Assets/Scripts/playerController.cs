using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Variables 
    Rigidbody2D rb;

    //[SerializeField] float moveSpeedUp;
    //[SerializeField] float moveSpeedDown;

    public float forceApplied;
    // ---------------------------------------------------------------------------

    // Enable script to access Ridgidbody component
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Detect input and add velocity to player object. Play sound effect.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Game Events/Player_Move");
            rb.velocity = (Vector2.up * forceApplied);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Game Events/Player_Move");
            rb.velocity = (Vector2.down * forceApplied);
        }
    }
}
