using UnityEngine;
using UnityEngine.InputSystem;

namespace DapperDino.Tutorials.Raycasting
{
    public class RaycastExample : MonoBehaviour
    {
        [SerializeField] private float distance = 10f;

        private Camera mainCamera;

        private void Start() => mainCamera = Camera.main;

        private void Update()
        {
            if (!Mouse.current.leftButton.wasPressedThisFrame) { return; }

            FireRaycast();
        }

        private void FireRaycast()
        {
            Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());

            Debug.DrawRay(ray.origin, ray.direction * distance, Color.red, 1f);
            if (Physics.Raycast(ray, out RaycastHit hit, distance))
            {
                hit.collider.GetComponent<Renderer>().material.SetColor("_BaseColor", new Color
                {
                    r = Random.Range(0f, 1f),
                    g = Random.Range(0f, 1f),
                    b = Random.Range(0f, 1f)
                });
            }
        }
    }
}
