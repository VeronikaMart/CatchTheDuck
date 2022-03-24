using UnityEngine;

namespace GameOver
{
    public class TotalScoreCalculator : MonoBehaviour
    {
        [SerializeField] private IntVariable
            currentScore,
            duckScore,
            highScore,
            totalScore;

        public void CalculateTotalScore()
        {
            var total = currentScore.value + duckScore.value;
            totalScore.SetValue(total);

            if (totalScore.value > highScore.value)
            {
                highScore.SetValue(total);
            }
        }
    }
}