using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    // Variables


    [SerializeField] float minSpawnTime;
    [SerializeField] float maxSpawnTime;

    [SerializeField] float minSpawnHeight;
    [SerializeField] float maxSpawnHeight;

    [SerializeField] float objectSpawnSpeed;

    [SerializeField] float playerSpeed;

    playerController controller;

    [SerializeField] GameObject obstacle;

    [SerializeField] Vector2 gravity;

    // Manipulation variables
    /*
    [SerializeField] float gravityDecrease;
    [SerializeField] float playerSpeedIncrease;
    [SerializeField] float objectSpeedIncrease;
    */
    // -------------------------------------------------------------------------------------------------------------------------------------

    // On Enable Invoke Obstacle Spawning after (range between spawn Time) seconds. Repeat every (range between spawn Time) seconds.
    private void OnEnable()
    {
        InvokeRepeating(nameof(spawn_Obstacle), Random.Range(minSpawnTime, maxSpawnTime), Random.Range(minSpawnTime, maxSpawnTime));

        gravity = Physics2D.gravity;
        controller = GameObject.FindObjectOfType<playerController>();
    }

    // Stop Invoke when disabled
    private void OnDisable()
    {
        CancelInvoke(nameof(spawn_Obstacle));
    }

    // Instantiate prefab object at current position.
    private void spawn_Obstacle()
    {
        GameObject spawn = Instantiate(obstacle, transform.position, Quaternion.identity);
        spawn.transform.position += Vector3.up * Random.Range(minSpawnHeight, maxSpawnHeight);
        spawn.GetComponent<objectMover>().objectSpeed = objectSpawnSpeed;
    }

    private void Update()
    {
        controller.forceApplied = playerSpeed;
        Physics2D.gravity = gravity;
        /*
        if (Input.GetKeyDown(KeyCode.P))
        {
            CancelInvoke(nameof(spawn_Obstacle));
            controller.forceApplied = playerSpeed;
            print(controller.forceApplied);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            CancelInvoke(nameof(spawn_Obstacle));;
            Physics2D.gravity = gravity;
            print(Physics2D.gravity);
        }
        */
    }
}
