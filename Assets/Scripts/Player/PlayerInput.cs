using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private PlayerControls controller;
        private PlayerMovement playerMovement;

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }

        private void Update()
        { 
            GetInput(); 
        }

        private void GetInput()
        {
            switch (controller)
            {
                case PlayerControls.KEYBOARD:
                    GetKeyboard();
                    break;
                case PlayerControls.TOUCHPAD:
                    GetTouchpad();
                    break;
                default:
                    break;
            }
        }

        private void GetTouchpad()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                float horizontalDirection = touch.position.x;

                if(touch.phase == TouchPhase.Began)
                {
                    if (horizontalDirection > Screen.width / 2)
                    {
                        playerMovement.Move(horizontalDirection);
                    }

                    else
                    {
                        playerMovement.Move(-horizontalDirection);
                    }
                }
            }
        }

        private void GetKeyboard()
        {
            float horizontalDirection = Input.GetAxisRaw("Horizontal");

            if (horizontalDirection > 0 || horizontalDirection < 0)
            {
                playerMovement.Move(horizontalDirection);
            }
        }
    }
}