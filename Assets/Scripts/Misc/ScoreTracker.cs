using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] private GameEvent GameEvent;
    [SerializeField] private IntReference currentScore, highScore;
    private bool reachedNewScore;

    private void Update()
    {
        if (!reachedNewScore)
        {
            if (currentScore > highScore && highScore > 0)
            {
                GameEvent.TriggerEvent();
                reachedNewScore = true;
            }
        }
    }
}