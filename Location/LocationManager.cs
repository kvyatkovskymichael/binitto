using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Application.Location
{
    public class LocationManager : MonoBehaviour
    {
        public GameObject platform;
        public float timer;
        public float resetTimerValue;
        public float spawnOffset;
        public Vector3 lastPlatformPosition;

        private void Start()
        {
            lastPlatformPosition = platform.transform.position;
        }

        private void InstantiatePlatform()
        {
            float posX = Random.Range(-3f, 3f);
            Vector3 pos = new Vector3(posX, lastPlatformPosition.y + spawnOffset, lastPlatformPosition.z);
            if(Instantiate(platform, pos, Quaternion.identity))
            {
                lastPlatformPosition = pos;
            }
        }

        private void Update()
        {
            if(timer <= 0f)
            {
                InstantiatePlatform();
                timer = resetTimerValue;
            }
            else
            {
                timer -= Time.deltaTime;
            }
        }

    }

}
