using Controllers.SO;
using UnityEngine;

public class GameLoad : MonoBehaviour
{
    [SerializeField] private SaveGameController saveGameController;

    private void Awake()
    {
        saveGameController.LoadGame();
    }
}