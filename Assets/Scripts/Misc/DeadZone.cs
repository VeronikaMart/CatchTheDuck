using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField] GameEvent PlayerDeathEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerDeathEvent.TriggerEvent();
            Destroy(collision.gameObject);
        }
    }
}