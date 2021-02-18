using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public class Player : MonoBehaviour
    {
        public float force;
        public float forceMultiplier = 1.0f;
        public bool invincibility = false;
        public int itemCount = 0;

        protected Rigidbody playerRigidbody;

        protected virtual void Start()
        {
            playerRigidbody = gameObject.GetComponent<Rigidbody>();
        }

        protected virtual void OnTriggerEnter(Collider trigger)
        {
            var item = trigger.GetComponent<InteractiveItem>();

            if(item != null)
                item.Activate(this);
        }
    }
}
