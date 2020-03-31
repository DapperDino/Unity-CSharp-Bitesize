using UnityEngine;

namespace DapperDino.Tutorials.Interfaces
{
    public class DealDamageOnContact : MonoBehaviour
    {
        [SerializeField] private float damageAmount = 10f;

        private void OnTriggerEnter(Collider other)
        {
            if(!other.TryGetComponent<IDamageable>(out var damageable))
            {
                return;
            }

            damageable.DealDamage(damageAmount);
        }
    }
}
