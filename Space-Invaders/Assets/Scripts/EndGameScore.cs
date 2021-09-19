using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGameScore : MonoBehaviour
{

    public Invaders enemies;
    public ShipSpawner ship;    
    public TMP_Text scoreText;    
    public int SCORE = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.SCORE = (enemies.amountKilled * 100) + (ship.amountOfShipsKilled * 500);
        scoreText.text = this.SCORE.ToString();    
    }
}
