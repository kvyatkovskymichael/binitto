using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Application
{
    public class Config : MonoBehaviour
    {
        private float _maxScreenWidth = 3f;
        public static Config instance;
        
        public float MaxScreenWidth
        {
            get
            {
                return _maxScreenWidth;
            }
        }

        private void Start()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance == this)
            {
                Destroy(gameObject);
            }

            
        }

    }
}

