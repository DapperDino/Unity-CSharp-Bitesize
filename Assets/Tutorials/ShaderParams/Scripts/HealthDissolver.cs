using UnityEngine;

namespace DapperDino.Tutorials.ShaderParams
{
    public class HealthDissolver : MonoBehaviour
    {
        [SerializeField] private Health health = null;
        [SerializeField] private Renderer[] healthRenderers = new Renderer[0];

        private float targetDissolveValue = 1f;
        private float currentDissolveValue = 1f;

        private void OnEnable() => health.OnHealthChanged += HandleHealthChanged;
        private void OnDisable() => health.OnHealthChanged -= HandleHealthChanged;

        private void Update()
        {
            currentDissolveValue = Mathf.Lerp(currentDissolveValue, targetDissolveValue, 2f * Time.deltaTime);

            foreach (Renderer renderer in healthRenderers)
            {
                renderer.material.SetFloat("_Health", currentDissolveValue);
            }
        }

        private void HandleHealthChanged(int health, int maxHealth)
        {
            targetDissolveValue = (float)health / maxHealth;
        }
    }
}
