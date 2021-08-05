using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Application.Player
{
    public class Bouncing
    {
        public static void Jump(Rigidbody rigidbody, Vector3 jumpDirection, float force, ForceMode forceMode)
        {
            rigidbody.AddForce(jumpDirection * force, forceMode);
        }
    }

}
