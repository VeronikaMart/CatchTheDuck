using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    [SerializeField] Settings settings;
    private Image image;

    private void Awake()
    {
        image = (Image)GetComponent("Image");
    }

    private void Start()
    {
        settings.CheckVolume(image);
    }
}