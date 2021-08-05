using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace Application.UI
{

    public class Arrow : MonoBehaviour, IPointerEnterHandler,
        IPointerMoveHandler,
        IPointerExitHandler
    {
        public MovementDirection movementDirection;
        public MovementDirection defaultMovementDirection;
        public void OnPointerEnter(PointerEventData eventData)
        {
            InputManager.instance.InputHorizontalAxis(movementDirection);
        }

        public void OnPointerMove(PointerEventData eventData)
        {
            InputManager.instance.InputHorizontalAxis(movementDirection);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            InputManager.instance.InputHorizontalAxis(defaultMovementDirection);
        }
    }

}