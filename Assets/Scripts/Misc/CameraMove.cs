using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    [Range(0,10)]
    private float maxSpeed = 5.2f;
    private float acceleraton = .2f;
    private float speed = 1f;
    private bool cameraMoved;

    private void Update()
    {
        if (cameraMoved)
        {
            MoveCamera();
        }
    }

    // If button pressed
    public void MoveCamera(bool state) 
    { 
        cameraMoved = state; 
    }

    private void MoveCamera()
    {
        Vector3 currentPos = transform.position;

        float oldY = currentPos.y;
        float newY = currentPos.y - (speed * Time.deltaTime);

        currentPos.y = Mathf.Clamp(currentPos.y, oldY, newY);
        transform.position = currentPos;

        speed += acceleraton * Time.deltaTime;

        if (speed > maxSpeed)
        {
            speed = maxSpeed;
        }
    }
}