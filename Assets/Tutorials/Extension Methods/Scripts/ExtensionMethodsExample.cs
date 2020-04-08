using UnityEngine;

namespace DapperDino.Tutorials.ExtensionMethods
{
    public class ExtensionMethodsExample : MonoBehaviour
    {
        private void Start()
        {
            transform.DestroyChildren();
        }
    }

    public static class ExtensionMethods
    {
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            if (gameObject.TryGetComponent(out T requestedComponent))
            {
                return requestedComponent;
            }

            return gameObject.AddComponent<T>();
        }

        public static void DestroyChildren(this Transform transform)
        {
            foreach(Transform child in transform)
            {
                Object.Destroy(child.gameObject);
            }
        }
    }
}
