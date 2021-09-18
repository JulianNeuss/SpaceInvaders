using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{

    public AudioSource Audio;

    public AudioClip Shoot;

    public AudioClip AlienKilled;

    public static SFXManager SFXManagerInstance;


    public void Awake()
    {
        if(SFXManagerInstance != null && SFXManagerInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        SFXManagerInstance = this;
        DontDestroyOnLoad(this);
    }
}
