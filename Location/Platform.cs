using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Application.Location
{
    public class Platform : MonoBehaviour
    {
        private Transform _transform;
        private float _speed;
        private short _directionModifier = 1;
        private float _maxScreenWidth;
        private Collider _collider;
        private void Start()
        {
            _maxScreenWidth = Config.instance.MaxScreenWidth;
            _speed = Random.Range(1f, 7f) * 0.01f;
            _transform = transform;
            _collider = GetComponent<Collider>();
       
        }

        private void OnTriggerEnter(Collider col)
        {
            if (col.transform.tag == "ClearPlatform"
                &&
                col.isTrigger)
            {
                Destroy(gameObject);
            }
        }
        

        private void Update()
        {
            if(Mathf.Abs(_transform.position.x) >= _maxScreenWidth)
            {
                _directionModifier *= -1;
            }
            _transform.Translate(_transform.right * _speed * _directionModifier);

            if(Context.instance.player.position.y > _transform.position.y)
            {
                _collider.isTrigger = false;
            }
            else
            {
                _collider.isTrigger = true;
            }
        }
    }
}
