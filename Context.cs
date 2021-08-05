using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Application
{
    public class Context : MonoBehaviour
    {
        public Transform player;
        public static Context instance;

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


            

            player = GameObject.Find("Player").transform;
        }

        
    }
}
