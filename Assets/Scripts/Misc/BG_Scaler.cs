using UnityEngine;

public class BG_Scaler : MonoBehaviour
{
    // Fit background to screen parameters
    private void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        Vector3 tempScale = transform.localScale;

        float width = renderer.sprite.bounds.size.x;
        float worldHeight = Camera.main.orthographicSize * 2;
        float worldWidth = worldHeight / Screen.height * Screen.width;

        tempScale.x = worldWidth / width;
        transform.localScale = tempScale;
    }
}