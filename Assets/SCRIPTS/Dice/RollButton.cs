using UnityEngine;

public class RollButton : MonoBehaviour
{
    public GameController gameController;

    public void OnRollButtonClicked()
    {
        gameController.RollAllDices();
    }
}
