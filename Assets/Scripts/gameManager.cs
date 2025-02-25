using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    // Variables

    [SerializeField] float minSpawnTime, maxSpawnTime, minSpawnHeight, maxSpawnHeight, objectSpawnSpeed, playerSpeed;

    public float scoreMulti;

    playerController controller;

    [SerializeField] GameObject obstacle;

    [SerializeField] Vector2 gravity;
    
    // -------------------------------------------------------------------------------------------------------------------------------------

    // On Enable Invoke Obstacle Spawning after (range between spawn Time) seconds. Repeat every (range between spawn Time) seconds.
    private void OnEnable()
    {
        StartCoroutine(spawn_Obstacle(Random.Range(minSpawnTime, maxSpawnTime)));
        StartCoroutine(valueManipulator(10f));
        scoreMulti = 1f;
        gravity = Physics2D.gravity;
        controller = GameObject.FindObjectOfType<playerController>();
    }

    // Stop Invoke when disabled
    private void OnDisable()
    {
        CancelInvoke(nameof(spawn_Obstacle));
    }

    // Instantiate prefab object at position of GameObject script is attatched to.
    private IEnumerator spawn_Obstacle(float delay)
    {
        yield return new WaitForSeconds(delay);

        while (true)
        {
            GameObject spawn = Instantiate(obstacle, transform.position, Quaternion.identity);
            spawn.transform.position += Vector3.up * Random.Range(minSpawnHeight, maxSpawnHeight);
            spawn.GetComponent<objectMover>().objectSpeed = objectSpawnSpeed;
            delay = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(delay);
        }

    }

    private IEnumerator valueManipulator(float delay)
    {
        yield return new WaitForSeconds(delay);

        while (true)
        {
            if (playerSpeed! <= 10)
            {
                playerSpeed += 0.5f;
            }

            if (maxSpawnTime! >= 1.5f)
            {
                maxSpawnTime -= 0.5f;
            }
            if (minSpawnTime > 0.5f)
            {
                minSpawnTime -= 0.5f;
            }

            scoreMulti += 0.5f;
            objectSpawnSpeed++;

            yield return new WaitForSeconds(delay);
        }


    }

    private void Update()
    {
        controller.forceApplied = playerSpeed;
        Physics2D.gravity = gravity;
    }
}
