using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RollingDice : MonoBehaviour
{
    [Header("References"), Space(5)]
    public GameObject[] dicesArray;
    public GameController gameControllerScript;
    

    private void OnMouseDown()
    {
        RollAllDices();
    }

    private void RollAllDices()
    {
        foreach (var dice in dicesArray)
        {
            //dice.RollDice();
        }
        gameControllerScript.CalculateScore();
    }
}
