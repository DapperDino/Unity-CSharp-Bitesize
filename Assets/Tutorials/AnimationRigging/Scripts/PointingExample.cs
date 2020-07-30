using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.InputSystem;

namespace DapperDino.Tutorials.AnimationRigging
{
    public class PointingExample : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] Rig rig = null;

        [Header("Settings")]
        [SerializeField] private float pointSpeed = 1f;

        private int targetValue;

        private void Update()
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                targetValue = targetValue == 0 ? 1 : 0;
            }

            rig.weight = Mathf.MoveTowards(rig.weight, targetValue, pointSpeed * Time.deltaTime);
        }
    }
}
