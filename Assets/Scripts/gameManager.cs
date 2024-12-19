using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    // Variables

    [SerializeField] GameObject obstacle;

    [SerializeField] float minSpawnTime;
    [SerializeField] float maxSpawnTime;

    [SerializeField] float minSpawnHeight;
    [SerializeField] float maxSpawnHeight;

    [SerializeField] float objectSpawnSpeed;

    playerController controller;
    [SerializeField] float playerSpeed;

    [SerializeField] Vector2 gravity;

    // -------------------------------------------------------------------------------------------------------------------------------------

    // On Enable Invoke Obstacle Spawning after (range between spawn Time) seconds. Repeat every (range between spawn Time) seconds.
    private void OnEnable()
    {
        InvokeRepeating(nameof(spawn_Obstacle), Random.Range(minSpawnTime, maxSpawnTime), Random.Range(minSpawnTime, maxSpawnTime));

        print(Physics2D.gravity);

        gravity = Physics2D.gravity;
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
        if (Input.GetKeyDown(KeyCode.P))
        {
            CancelInvoke(nameof(spawn_Obstacle));
            controller = GameObject.FindObjectOfType<playerController>();
            controller.forceApplied = playerSpeed;
            print(controller.forceApplied);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            CancelInvoke(nameof(spawn_Obstacle));;
            Physics2D.gravity = gravity;
            print(Physics2D.gravity);
        }
    }
}
