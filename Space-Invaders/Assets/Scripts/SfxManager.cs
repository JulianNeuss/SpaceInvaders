using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{ 
    public AudioSource Audio;

    public AudioClip Shot;

    public AudioClip AlienExplosion;

    public AudioClip PlayerHitted;

    public AudioClip PlayerLoose;

    public AudioClip PlayerWins;

    public static SfxManager sfxInstance;
        
    // Start is called before the first frame update
    private void Awake()
    {
        if(sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        sfxInstance = this;
        DontDestroyOnLoad(this);
    }

}
