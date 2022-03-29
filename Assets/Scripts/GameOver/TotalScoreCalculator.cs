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
            var total = currentScore.IntValue + duckScore.IntValue;
            totalScore.IntValue = total;

            if (totalScore.IntValue > highScore.IntValue)
            {
                highScore.IntValue = total;
            }
        }
    }
}