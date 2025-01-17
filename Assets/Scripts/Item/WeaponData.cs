using UnityEngine;

namespace Prototype_S
{
    /*
     * Responsible for any kind of weapon config applied to a weapon.
     */
    public class WeaponConfig : ScriptableObject
    {
        public string weaponName;
        public Sprite icon;
        public int manaCost;
        public float cooldown = ;
        
    }
}