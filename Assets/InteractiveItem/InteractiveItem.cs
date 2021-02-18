using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public abstract class InteractiveItem : MonoBehaviour
    {
        protected Vector3 position;
        protected float radius;
        protected Coroutine bonusCoroutine;

        public InteractiveItem()
        {
            position = new Vector3(0.0f, 0.0f, 0.0f);
            radius = 1.0f;
        }

        public abstract void Activate(Player player);
    }
}
