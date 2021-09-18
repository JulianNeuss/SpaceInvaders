using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{



    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject inGameMusic;
    // public GameObject SoundFX;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }else{
                Pause();
            }
        }
    }

    public void Resume(){
        SFXManager.SFXManagerInstance.Audio.PlayOneShot(SFXManager.SFXManagerInstance.Click);
        pauseMenuUI.SetActive(false);
        inGameMusic.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        inGameMusic.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu(){
        SFXManager.SFXManagerInstance.Audio.PlayOneShot(SFXManager.SFXManagerInstance.Click);
        Resume();
        SceneManager.LoadScene(0);
    }

    public void QuitGame(){
        SFXManager.SFXManagerInstance.Audio.PlayOneShot(SFXManager.SFXManagerInstance.Click);
        Application.Quit();
    }

    // public void SwitchSounds(){
    //     SFXManager Sound = SoundFX.GetComponent<SFXManager>();
    //     if(Sound.isActive){
    //         SoundFX.SetActive(false);
    //         Sound.onOffSound();
    //     }
    //     else{
    //         SoundFX.SetActive(true);
    //         Sound.onOffSound();
    //     }
        
    // }

    public void RestartGame(){
        SFXManager.SFXManagerInstance.Audio.PlayOneShot(SFXManager.SFXManagerInstance.Click);
        Resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
