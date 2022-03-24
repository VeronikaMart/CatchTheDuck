using TMPro;
using UnityEngine;

namespace Player
{
    public class PlayerHUD : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI
            currentScore,
            highScore,
            duckAmount;
        [SerializeField] private IntReference
            currentScoreReference,
            highScoreReference,
            duckAmountReference;

        private void Start() 
        {
            DisplayHigh();
        } 

        private void Update()
        {
            DisplayCurrent();
        }

        public void DisplayDuck()
        {
            duckAmount.text = $"x{duckAmountReference.Value}";
        }

        private void DisplayCurrent()
        {
            currentScore.text = $"Current: {currentScoreReference.Value}";
        }

        private void DisplayHigh()
        {
            highScore.text = $"Best: {highScoreReference.Value}";
        }
    }
}