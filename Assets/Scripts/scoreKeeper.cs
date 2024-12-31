using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreKeeper : MonoBehaviour
{
    int playerScore;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Game")
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
