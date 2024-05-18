using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Dice[] dices;
    public Text scoreText;
    private int playerScore;

    void Start()
    {
        playerScore = 0;
        UpdateScore();
    }

    public void RollAllDices()
    {
        foreach (Dice dice in dices)
        {
            dice.RollDice();
        }
        CalculateScore();
    }

    private void CalculateScore()
    {
        // Ajoute ici la logique pour calculer le score basé sur les dés lancés
        // Pour l'instant, on va juste incrémenter le score de façon arbitraire pour tester
        playerScore += Random.Range(1, 7);
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + playerScore.ToString();
    }
}
