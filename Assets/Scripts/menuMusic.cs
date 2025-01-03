using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuMusic : MonoBehaviour
{
    private FMOD.Studio.EventInstance music;
    // Start is called before the first frame update
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
