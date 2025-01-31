using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreKeeper : MonoBehaviour
{
    // Variables

    float playerScore = 0;

    // ---------------------------------------------------------------------------

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnLevelWasLoaded(int level)
    {
        if (level == 0)
        {
            Destroy(gameObject);
        }    
        if(level == 1)
        {
            playerScore = 0;
        }
    }
    public void addToScore(float multi)
    {
        playerScore += 10 * multi;
        FMODUnity.RuntimeManager.PlayOneShot("event:/Game Events/Player_Score");
    }

    public float getScore()
    {
        return playerScore;
    }
}
