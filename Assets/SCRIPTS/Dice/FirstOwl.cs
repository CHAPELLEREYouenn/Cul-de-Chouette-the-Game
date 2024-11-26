using UnityEngine;
using Random = UnityEngine.Random;

public class FirstOwl : MonoBehaviour
{
    [Header("References"), Space(5)]
    public Sprite[] diceSides; // Assurez-vous que les sprites sont attribu�s dans l'inspecteur
    [SerializeField] private SpriteRenderer diceImage;
    public GameController gameController;

    [Header("Variables"), Space(5)] 
    public int randomSide;
    public int score;

    [Header("Access"), Space(5)]
    public static FirstOwl firstOwlInstance;
    
    void Start()
    {
        if (firstOwlInstance != null)
        {
            Debug.LogWarning("Il y a déjà une instance de FirstOwl dans la scène");
            return;
        }

        firstOwlInstance = this;

        diceImage = GetComponent<SpriteRenderer>();        
        diceImage.sprite = diceSides[5];
    }

    public void RollDice()
    {
        randomSide = Random.Range(1, 7); // parametre de Range (en interval) -> [min, max[
        score = randomSide;
        diceImage.sprite = diceSides[randomSide -1];
    }
}
