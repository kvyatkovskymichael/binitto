using UnityEngine;

namespace Application.Player
{
    public class PlayerData : MonoBehaviour
    {
        private float _jumpForce;
        private float _health;
        private float _movementSpeed;
        private const float SPEED_MODIFIER = 0.01f;

        public float JumpForce
        {
            get
            {
                return _jumpForce;
            }

            set
            {
                _jumpForce = value;
            }
        }

        public float Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }

        public float MovementSpeed
        {
            get
            {
                return _movementSpeed;
            }
        }

        public PlayerData(float health, float jumpForce, float movementSpeed)
        {
            this._health = health;
            this._jumpForce = jumpForce;
            this._movementSpeed = movementSpeed * SPEED_MODIFIER;
        }
    }

}
