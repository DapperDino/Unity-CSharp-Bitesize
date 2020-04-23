using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DapperDino.Tutorials.MouseEvents
{
    public class MouseEventsExample : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        [SerializeField] private Image image = null;

        public void OnPointerEnter(PointerEventData eventData)
        {
            image.color = new Color(1, 0, 0, 1);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            image.color = new Color(1, 1, 1, 1);
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Mouse.current.position.ReadValue();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            Debug.Log("Up");
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log("Down");
        }
    }
}
