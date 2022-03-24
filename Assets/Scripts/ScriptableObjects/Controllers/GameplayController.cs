using UnityEngine;

namespace Controllers.SO
{
    [CreateAssetMenu(fileName = "GameplayController", menuName = "Scriptable Objects/Controllers/Gameplay Controller")]
    public class GameplayController : ScriptableObject
    {
        public void PauseGame(bool paused)
        {
            if (paused)
                Time.timeScale = 0;

            else
                Time.timeScale = 1;
        }

        public void ExitGame() 
        { 
            Application.Quit(); 
        }
    }
}