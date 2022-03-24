using UnityEngine;
using UnityEngine.Events;

namespace Collectable.Object
{
    public class Collectable : MonoBehaviour, ICollectable
    {
        [SerializeField] private GameEvent ScoreChangedEvent;
        [SerializeField] private UnityEvent CollectableEvent;
        [Range(0, 100)]
        [SerializeField] private int dropChance;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                Collect();
            }
        }

        public void DropCollectable(Vector3 pos, Transform parent)
        {
            int percent = Random.Range(0, 101);

            if (percent <= dropChance)
            {
                Instantiate(gameObject, pos, Quaternion.identity, parent);
            }
        }

        private void Collect()
        {
            CollectableEvent.Invoke();
            ScoreChangedEvent.TriggerEvent();
            Destroy(gameObject, .2f);
        }
    }
}