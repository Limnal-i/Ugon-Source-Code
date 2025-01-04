using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreKeeper : MonoBehaviour
{
    float playerScore = 0;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnLevelWasLoaded(int level)
    {
        if(level == 1)
        {
            playerScore = 0;
        }
    }
    public void addToScore(float multi)
    {
        playerScore += 10 * multi;
    }

    public float getScore()
    {
        return playerScore;
    }
}
