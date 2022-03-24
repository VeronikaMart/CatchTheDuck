using UnityEngine;

namespace Collectable.Object
{
    public class CollectableSpawner : MonoBehaviour
    {
        [SerializeField] private Collectable collecatble;
        [SerializeField] private GameObject target;

        private void Start() 
        {
            collecatble.DropCollectable(target.transform.position, transform.parent);
        }
    }
}