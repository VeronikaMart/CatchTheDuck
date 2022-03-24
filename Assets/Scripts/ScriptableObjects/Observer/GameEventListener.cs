using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [Tooltip("Event to trigger with.")]
    [SerializeField] private GameEvent gameEvent;
    [Tooltip("Response to invoke when Event is triggered.")]
    [SerializeField] private UnityEvent onEventTriggered;

    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventTriggered()
    {
        onEventTriggered.Invoke();
    }
}