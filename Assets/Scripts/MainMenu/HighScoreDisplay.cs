using TMPro;
using UnityEngine;

namespace MainMenu
{
    public class HighScoreDisplay : MonoBehaviour
    {
        [SerializeField] private IntReference highScore;
        [SerializeField] private TextMeshProUGUI highScoreText;

        private void OnEnable() 
        { 
            highScoreText.text = $"High score: \n{highScore.Value}"; 
        }
    }
}