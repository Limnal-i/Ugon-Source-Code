using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeeper : MonoBehaviour
{
    int playerScore = 0;

    public void addToScore()
    {
        playerScore++;
    }

    public int getScore()
    {
        return playerScore;
    }
}
