using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_Movement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float moveSpeedUp;
    [SerializeField] float moveSpeedDown;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //rb.AddForce(Vector2.up * moveSpeed);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Test Events/TestEvent");
            rb.velocity = (Vector2.up * moveSpeedUp);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //rb.AddForce(Vector2.up * moveSpeed);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Test Events/TestEvent");
            rb.velocity = (Vector2.down * moveSpeedDown);
        }
    }
}
