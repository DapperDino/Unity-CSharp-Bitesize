using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace DapperDino.Tutorials.Navigation
{
    public class NavigationExample : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent navMeshAgent = null;

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

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                navMeshAgent.SetDestination(hit.point);
            }
        }
    }
}
