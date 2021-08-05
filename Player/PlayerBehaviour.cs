using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Application.Player
{
    public class PlayerBehaviour : MonoBehaviour
    {
        private Rigidbody _rb;
        private Transform _transform;
        private PlayerData _data;
        public bool _jumpAllow;

        private void Start()
        {
            Initialize();
            _data = new PlayerData(100f, 15f, 3f);
            
        }
        public void Move()
        {
            _transform.Translate(_transform.right * InputManager.instance.HorizontalAxis * _data.MovementSpeed);
            
        }
        public void Initialize()
        {
            _transform = transform;
            _rb = GetComponent<Rigidbody>();
        }
        public void OnJump()
        {
            if(_jumpAllow)
            {
                Bouncing.Jump(_rb, _transform.up, _data.JumpForce, ForceMode.Impulse);
            }
            
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.transform.tag == "Platform")
            {
                _jumpAllow = true;
                _transform.SetParent(collision.transform);
            }
        }
       
        private void OnCollisionExit(Collision collision)
        {
            if (collision.transform.tag == "Platform")
            {
                _transform.SetParent(null);
                _jumpAllow = false;
            }
        }

        private void Update()
        {
            Move();

            if(Input.GetKeyDown(KeyCode.Space))
            {
                OnJump();
            }
        }
    }

}
