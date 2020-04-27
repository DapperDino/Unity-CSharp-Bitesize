using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DapperDino.Tutorials.MouseEvents
{
    public class MouseEventsExample : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IDragHandler, IPointerUpHandler, IDropHandler
    {
        private Image image;

        private Vector3 originalPos;

        private void Start() => image = GetComponent<Image>();

        public void OnPointerEnter(PointerEventData eventData)
        {
            image.color = new Color(1, 0, 0, 1);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            image.color = new Color(1, 1, 1, 1);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            originalPos = transform.position;
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Mouse.current.position.ReadValue();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            transform.position = originalPos;
        }

        public void OnDrop(PointerEventData eventData)
        {
            var a = eventData.pointerDrag.gameObject;
        }
    }
}
