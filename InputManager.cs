using UnityEngine;

namespace Application
{

    public class InputManager : MonoBehaviour
    {
        public static InputManager instance;

        public float HorizontalAxis;

        private void Start()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if(instance == this)
            {
               Destroy(gameObject);
            }

            
        }


        public void InputHorizontalAxis(MovementDirection direction)
        {
            switch (direction)
            {
                case MovementDirection.Right:
                    this.HorizontalAxis = 1f;
                    break;

                case MovementDirection.Left:
                    this.HorizontalAxis = -1f;
                    break;
                case MovementDirection.None:
                    this.HorizontalAxis = 0f;
                    break;
            }
            
        }
    }
}
