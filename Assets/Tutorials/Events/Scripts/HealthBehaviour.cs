using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DapperDino.Tutorials.Events
{
    public class HealthBehaviour : MonoBehaviour
    {
        [SerializeField] private float maxHealth = 100;

        public event EventHandler<HealthChangedEventArgs> OnHealthChanged;

        public float MaxHealth => maxHealth;

        private float health;
        public float Health
        {
            get => health;
            private set
            {
                health = Mathf.Clamp(value, 0, maxHealth);

                OnHealthChanged?.Invoke(this, new HealthChangedEventArgs
                {
                    Health = health,
                    MaxHealth = maxHealth
                });
            }
        }

        private void Start() => Health = maxHealth;

        private void Update()
        {
            if (!Keyboard.current.spaceKey.wasPressedThisFrame) { return; }

            Remove(10f);
        }

        private void Add(float value)
        {
            value = Mathf.Max(value, 0f);

            Health += value;
        }

        private void Remove(float value)
        {
            value = Mathf.Max(value, 0f);

            Health -= value;
        }
    }

    public class HealthChangedEventArgs : EventArgs
    {
        public float Health { get; set; }
        public float MaxHealth { get; set; }
    }
}
