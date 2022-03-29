using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    public class PlayerScoreCalculator : MonoBehaviour
    {
        [SerializeField] private BoolVariable gamePlaying;
        [SerializeField] private UnityEvent ScoreEvent;

        private void Update()
        {
            if (gamePlaying)
            {
                ScoreEvent.Invoke();
            }
        }

        public void CalculateCurrentScore(IntVariable currentScore)
        {
            float playerPosY = transform.position.y;

            if (playerPosY <= 0)
            {
                currentScore.IntValue = Mathf.Abs((int)playerPosY);
            }
        }
    }
}