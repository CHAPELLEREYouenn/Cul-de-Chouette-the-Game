using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Dice : MonoBehaviour
{
    [Header("References"), Space(5)]
    public Dice[] dices;
    public Sprite[] diceSides; // Assurez-vous que les sprites sont attribu�s dans l'inspecteur
    [SerializeField] private SpriteRenderer diceImage;
    public GameController gameController;

    [Header("Variables"), Space(5)] 
    public int randomSide;
    public int score;
    
    void Start()
    {
        diceImage = GetComponent<SpriteRenderer>();
        
        diceImage.sprite = diceSides[5];
    }

    private void OnMouseDown()
    {
        RollAllDices();
    }

    private void RollDice()
    {
        randomSide = Random.Range(1, 7); // parametre de Range (en interval) -> [min, max[
        score = randomSide;
        diceImage.sprite = diceSides[randomSide -1];
    }
    
    private void RollAllDices()
    {
        foreach (var dice in dices)
        {
            RollDice();
        }
        gameController.CalculateScore();
    }
}
