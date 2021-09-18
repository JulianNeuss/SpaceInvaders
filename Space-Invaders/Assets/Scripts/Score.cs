using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public Invaders enemies;
    public int SCORE = 0;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.SCORE = enemies.amountKilled * 100;
        scoreText.text = this.SCORE.ToString();
    }
}
