using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public sealed class Slowdown : InteractiveItem
    {
        public int bonusTime = 15;
        public float forceMultiplier = 0.5f;

        public override void Activate(Player player)
        {
            if(bonusCoroutine == null)
                bonusCoroutine = StartCoroutine(AddBonus(player));
        }

        private IEnumerator AddBonus(Player player)
        {
            player.forceMultiplier *= forceMultiplier;
            yield return new WaitForSeconds(bonusTime);
            if(bonusCoroutine != null)
            {
                StopCoroutine(bonusCoroutine);
                bonusCoroutine = null;
            }
            player.forceMultiplier /= forceMultiplier;
        }
    }
}
