using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DapperDino.Tutorials.Coroutines
{
    public class CoroutineExample : MonoBehaviour
    {
        [SerializeField] private float duration = 2f;

        private bool isScaling = false;

        private void Update()
        {
            if (!Keyboard.current.spaceKey.wasPressedThisFrame || isScaling) { return; }

            StartCoroutine(DoSomething());
        }

        private IEnumerator DoSomething()
        {
            isScaling = true;

            float timer = 0f;
            while (timer < duration)
            {
                timer += Time.deltaTime;
                transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, timer / duration);
                yield return null;
            }

            transform.localScale = Vector3.zero;

            yield return new WaitForSeconds(1f);

            timer = 0f;
            while (timer < duration)
            {
                timer += Time.deltaTime;
                transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer / duration);
                yield return null;
            }

            transform.localScale = Vector3.one;

            isScaling = false;
        }
    }
}
