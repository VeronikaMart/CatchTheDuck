using UnityEngine;

namespace Collectable.Object
{
    public interface ICollectable
    {
        public void DropCollectable(Vector3 pos, Transform parent);
    }
}