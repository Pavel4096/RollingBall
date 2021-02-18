using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

namespace RollingBall
{
    public sealed class BallPlayer : Player
    {
        protected override void Start()
        {
            base.Start();
            Log("Start method called");
        }

        private void FixedUpdate()
        {
            Vector3 direction = new Vector3(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

            playerRigidbody.AddForce(direction.normalized*force*forceMultiplier);
        }
    }
}
