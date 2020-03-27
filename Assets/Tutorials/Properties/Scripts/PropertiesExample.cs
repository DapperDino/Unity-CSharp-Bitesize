using UnityEngine;

namespace DapperDino.Tutorials.Properties
{
    public class PropertiesExample : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;

        public float Speed => speed;

        private void Test()
        {
            speed--;
        }
    }

    public class TestingExample
    {
        private PropertiesExample propertiesExample;

        private void Test()
        {
            float a = propertiesExample.Speed;
        }
    }
}
