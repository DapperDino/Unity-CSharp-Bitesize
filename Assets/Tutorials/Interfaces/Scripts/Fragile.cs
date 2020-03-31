using UnityEngine;

namespace DapperDino.Tutorials.Interfaces
{
    public class Fragile : MonoBehaviour, IDamageable
    {
        public void DealDamage(float damageValue) => Destroy(gameObject);
    }
}
