using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o_Spawn : MonoBehaviour
{
    // Variables

    [SerializeField] GameObject obstacle;

    [SerializeField] float minSpawnAmount;
    [SerializeField] float maxSpawnAmount;

    [SerializeField] float minSpawnHeight;
    [SerializeField] float maxSpawnHeight;

    [SerializeField] float objectSpawnSpeed;

    // -------------------------------------------------------------------------------------------------------------------------------------

    // On Enable Invoke Obstacle Spawning after (range between spawn amount) seconds. Repeat every (range between spawn amount) seconds.
    private void OnEnable()
    {
        InvokeRepeating(nameof(spawn_Obstacle), Random.Range(minSpawnAmount, maxSpawnAmount), Random.Range(minSpawnAmount, maxSpawnAmount));
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
        spawn.GetComponent<o_Move>().objectSpeed = objectSpawnSpeed;
    }
}
