using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public sealed class CollectableItem : InteractiveItem
    {
        private bool collected = false;

        public override void Activate(Player player)
        {
            if(!collected)
            {
                collected = true;
                player.itemCount++;
            }
        }
    }
}
