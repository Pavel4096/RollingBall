using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public sealed class InvincibilityBonus : InteractiveItem
    {
        public int bonusTime = 15;

        public override void Activate(Player player)
        {
            if(bonusCoroutine == null)
                bonusCoroutine = StartCoroutine(AddBonus(player));
        }

        private IEnumerator AddBonus(Player player)
        {
            player.invincibility = true;
            yield return new WaitForSeconds(bonusTime);
            if(bonusCoroutine != null)
            {
                StopCoroutine(bonusCoroutine);
                bonusCoroutine = null;
            }
            player.invincibility = false;
        }
    }
}
