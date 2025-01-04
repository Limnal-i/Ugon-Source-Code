using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreKeeper : MonoBehaviour
{
    int playerScore = 0;

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
    public void addToScore()
    {
        playerScore++;
    }

    public int getScore()
    {
        return playerScore;
    }
}
