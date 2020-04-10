using UnityEngine;

namespace DapperDino.Tutorials.GizmoTools
{
    public class GizmosExample : MonoBehaviour
    {
        [SerializeField] private float spawnRadius = 5f;
        [SerializeField] private Transform followTarget = null;

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, spawnRadius);

            Gizmos.DrawIcon(transform.position, "Square.png", true);
        }

        private void OnDrawGizmosSelected()
        {
            if (followTarget != null)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawLine(transform.position, followTarget.position);
            }
        }
    }
}
