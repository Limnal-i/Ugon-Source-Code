using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuMusic : MonoBehaviour
{
    // Variables

    private FMOD.Studio.EventInstance music;

    // ---------------------------------------------------------------------------------

    void Start()
    {
        music = FMODUnity.RuntimeManager.CreateInstance("event:/Game Events/Music_Menu");
        music.start();
        music.release();
    }
    private void OnDestroy()
    {
        music.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }
}
