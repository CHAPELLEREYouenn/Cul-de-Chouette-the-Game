using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [Header("References"), Space(5)]
    public Text scoreText;
    //public Dice dice;
    
    [Header("Variables"), Space(5)]
    [SerializeField] private int playerScore;

    void Start()
    {
        playerScore = 0;
        UpdateScore();
    }

    public void CalculateScore()
    {
        //playerScore += dice.score;
        //Debug.Log(dice.score);
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + playerScore.ToString();
    }
}
