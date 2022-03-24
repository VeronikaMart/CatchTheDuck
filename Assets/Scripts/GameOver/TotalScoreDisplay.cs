using TMPro;
using UnityEngine;

namespace GameOver
{
    public class TotalScoreDisplay : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI totalScore;
        [SerializeField] private IntReference 
            currentScoreReference, 
            duckAmountReference,
            totalScoreReference;

        private void OnEnable() 
        {
            DisplayResult();
        }

        private void DisplayResult()
        {
            totalScore.text =
                $"Score: {currentScoreReference.Value}\n" +
                $" Ducks: +{duckAmountReference.Value}\n" +
                $" Total: {totalScoreReference.Value}";
        }
    }
}