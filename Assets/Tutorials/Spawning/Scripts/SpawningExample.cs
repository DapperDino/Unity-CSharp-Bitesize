using UnityEngine;
using UnityEngine.InputSystem;

namespace DapperDino.Tutorials.Spawning
{
    public class SpawningExample : MonoBehaviour
    {
        [SerializeField] private Rigidbody ballPrefab = null;

        private void Update()
        {
            if (!Keyboard.current.spaceKey.wasPressedThisFrame) { return; }

            SpawnBall();
        }

        private void SpawnBall()
        {
            Rigidbody ballInstance = Instantiate(ballPrefab, transform.position, transform.rotation);

            ballInstance.AddForce(Vector3.up * 10f, ForceMode.VelocityChange);
        }
    }
}
