using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Settings", menuName = "Scriptable Objects/Settings")]
public class Settings : ScriptableObject
{
    public bool volumeOn;
    [SerializeField] private Sprite musicOn;
    [SerializeField] private Sprite musicOff;

    public void ChangeVolume()
    {
        volumeOn = !volumeOn;
    }

    public void CheckVolume(Image image)
    {
        if (volumeOn)
        {
            AudioListener.volume = 1;
            image.sprite = musicOn;
        }

        else
        {
            AudioListener.volume = 0;
            image.sprite = musicOff;
        }
    }
}