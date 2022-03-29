using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Controllers.SO
{
    [CreateAssetMenu(fileName = "SaveGameController", menuName = "Scriptable Objects/Controllers/Save Game Controller")]
    public class SaveGameController : ScriptableObject
    {
        [SerializeField] private IntVariable highScore;

        public void SaveGame()
        {
            if (!FileSaved())
            {
                Directory.CreateDirectory(Application.persistentDataPath + "catch_the_duck/game_save");
            }

            if (!Directory.Exists(Application.persistentDataPath + "catch_the_duck/game_save/high_score"))
            {
                Directory.CreateDirectory(Application.persistentDataPath + "catch_the_duck/game_save/high_score");
            }

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "catch_the_duck/game_save/high_score/save.txt");

            var json = JsonUtility.ToJson(highScore);
            binaryFormatter.Serialize(file, json);
            file.Close();
        }

        public void LoadGame()
        {
            if (!Directory.Exists(Application.persistentDataPath + "catch_the_duck/game_save/high_score"))
            {
                Directory.CreateDirectory(Application.persistentDataPath + "catch_the_duck/game_save/high_score");
            }

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            if (File.Exists(Application.persistentDataPath + "catch_the_duck/game_save/high_score/save.txt"))
            {
                FileStream file = File.Open(Application.persistentDataPath + "catch_the_duck/game_save/high_score/save.txt", FileMode.Open);
                JsonUtility.FromJsonOverwrite((string)binaryFormatter.Deserialize(file), highScore);
                file.Close();
            }
        }

        private bool FileSaved() =>
            Directory.Exists(Application.persistentDataPath + "catch_the_duck/game_save");
    }
}