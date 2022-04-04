using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private AnimationCurve speedCurve;
        [SerializeField] private BoolVariable gamePlaying;

        private Rigidbody2D rb;
        private Animator animator;
        private SpriteRenderer facing;

        private void Awake()
        {
            rb = (Rigidbody2D)GetComponent("Rigidbody2D");
            animator = (Animator)GetComponent("Animator");
            facing = (SpriteRenderer)GetComponent("SpriteRenderer");
        }

        public void Move(float direction)
        {
            if (gamePlaying.State)
            {
                HorizontalMovement(direction);
                animator.SetTrigger("Walk");
            }
        }

        private void HorizontalMovement(float direction)
        {
            rb.velocity = new Vector2(speedCurve.Evaluate(direction), rb.velocity.y);

            if (direction < 0f || direction > 0f)
            {
                facing.flipX = direction < 0f;
            }
        }
    }
}