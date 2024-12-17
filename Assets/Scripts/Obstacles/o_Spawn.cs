using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o_Spawn : MonoBehaviour
{
    [SerializeField] GameObject obstacle;

    [SerializeField] float minSpawnAmount = 1f;
    [SerializeField] float maxSpawnAmount = 1f;

    [SerializeField] float minSpawnHeight = -1f;
    [SerializeField] float maxSpawnHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(spawn_Obstacle), Random.Range(minSpawnAmount, maxSpawnAmount), Random.Range(minSpawnAmount, maxSpawnAmount));
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(spawn_Obstacle));
    }

    private void spawn_Obstacle()
    {
        GameObject spawn = Instantiate(obstacle, transform.position, Quaternion.identity);
        spawn.transform.position += Vector3.up * Random.Range(minSpawnHeight, maxSpawnHeight);
    }
}
