using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public Invaders enemies;
    public ShipSpawner ship;
    public int SCORE = 0;
    public TMP_Text scoreText;
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
