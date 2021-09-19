using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameMenu : MonoBehaviour
{

    public GameObject inGameMusic;
    public GameObject endGameMenuUI;
    public GameObject endGameMenuMusic;

    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!this.player.isAlive){
            endGameMenuUI.SetActive(true);
            inGameMusic.SetActive(false);
            endGameMenuMusic.SetActive(true);
        }
    }
}
