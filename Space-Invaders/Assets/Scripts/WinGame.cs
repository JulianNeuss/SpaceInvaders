using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{

    public GameObject inGameMusic;
    public GameObject winGameMenuUI;
    public GameObject winGameMenuMusic;
 
    public Invaders enemies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.enemies.playerWon){
            winGameMenuUI.SetActive(true);
            inGameMusic.SetActive(false);
            winGameMenuMusic.SetActive(true);
        }
    }
}
