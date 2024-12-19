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

    // -------------------------------------------------------------------------------------------------------------------------------------

    // On Enable Invoke Obstacle Spawning after (range between spawn Time) seconds. Repeat every (range between spawn Time) seconds.
    private void OnEnable()
    {
        InvokeRepeating(nameof(spawn_Obstacle), Random.Range(minSpawnTime, maxSpawnTime), Random.Range(minSpawnTime, maxSpawnTime));
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
}
