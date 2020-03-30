using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DapperDino.Tutorials.Events
{
    public class EventsExample : MonoBehaviour
    {
        [SerializeField] private HealthBehaviour healthBehaviour = null;

        [Header("UI")]
        [SerializeField] private Image healthBarImage = null;
        [SerializeField] private TMP_Text healthText = null;

        private void OnEnable()
        {
            UpdateHealthBar(healthBehaviour.Health, healthBehaviour.MaxHealth);

            healthBehaviour.OnHealthChanged += HandleHealthChanged;
        }

        private void OnDisable()
        {
            healthBehaviour.OnHealthChanged -= HandleHealthChanged;
        }

        private void HandleHealthChanged(object sender, HealthChangedEventArgs e)
        {
            UpdateHealthBar(e.Health, e.MaxHealth);
        }

        private void UpdateHealthBar(float health, float maxHealth)
        {
            healthText.text = $"{Mathf.Ceil(health)}/{Mathf.Ceil(maxHealth)}";
            healthBarImage.fillAmount = health / maxHealth;
        }
    }
}
