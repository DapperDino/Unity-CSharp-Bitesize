using UnityEngine;

namespace DapperDino.Tutorials.Ragdolls
{
    public class RagdollDeath : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Animator animator = null;

        private Rigidbody[] ragdollBodies;
        private Collider[] ragdollColliders;

        private void Start()
        {
            ragdollBodies = GetComponentsInChildren<Rigidbody>();
            ragdollColliders = GetComponentsInChildren<Collider>();

            ToggleRagdoll(false);

            Invoke(nameof(Die), 5f);
        }

        private void Die()
        {
            ToggleRagdoll(true);

            foreach(Rigidbody rb in ragdollBodies)
            {
                rb.AddExplosionForce(107f, new Vector3(-1f, 0.5f, -1f), 5f, 0f, ForceMode.Impulse);
            }
        }

        private void ToggleRagdoll(bool state)
        {
            animator.enabled = !state;

            foreach(Rigidbody rb in ragdollBodies)
            {
                rb.isKinematic = !state;
            }

            foreach (Collider collider in ragdollColliders)
            {
                collider.enabled = state;
            }
        }
    }
}
