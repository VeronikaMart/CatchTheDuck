using UnityEngine;

namespace Player
{
    public class PlayerBounds : MonoBehaviour, IBorder
    {
        private float minX, maxX;

        private void Start()
        {
            SetBoundaries();
        }

        private void Update()
        {
            if (transform.position.x < minX || transform.position.x > maxX)
            {
                ClampPosition();
            }
        }

        public void SetBoundaries()
        {
            Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

            maxX = bounds.x;
            minX = -bounds.x;
        }

        private void ClampPosition()
        {
            float rightPosition = Mathf.Clamp(transform.position.x, minX, maxX);

            Vector3 pos = transform.position;
            pos.x = rightPosition;
            transform.position = pos;
        }
    }
}