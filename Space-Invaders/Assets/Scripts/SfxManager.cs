using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{

    public AudioSource Audio;

    public AudioClip Shoot;

    public AudioClip AlienKilled;

    public AudioClip MysteryShipKilled;
    public AudioClip PlayerGotShot;
    // public AudioClip Win;
    public AudioClip Lose;

    public AudioClip Click;


    public static SFXManager SFXManagerInstance;


    public bool isActive = true;

    public void onOffSound(){
        this.isActive = !this.isActive;
    }

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
