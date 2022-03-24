using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers.SO
{
    [CreateAssetMenu(fileName = "SceneController", menuName = "Scriptable Objects/Controllers/Scene Controller")]
    public class SceneController : ScriptableObject
    {
        public void LoadScene(int index) 
        { 
            SceneManager.LoadScene(index); 
        }

        public void RestartGame() 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
    }
}