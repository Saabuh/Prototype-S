using UnityEditor.Rendering;
using UnityEngine;

namespace PlayerScripts
{
    /**
     * Equipment State: Attacking
     */
    [System.Serializable]
    public class AttackState : IPlayerState
    {
        
        public IPlayerState HandleInput()
        {
            if (Input.GetButtonUp("Fire1"))
            {
                //change to standby state
                return new StandbyState();
            }
            //stay in current state
            return null;
        }

        public void Update(Player player)
        {
            if (player.cooldown <= 0)
            {
                Fire(player);
                // Debug.Log("Fire");
                player.cooldown = player.cooldownDuration;
            }     
        }

        public void Fire(Player player)
        {
            
            
        }

        public void Enter()
        {
        }

        public void Exit()
        {
        }
    }
}