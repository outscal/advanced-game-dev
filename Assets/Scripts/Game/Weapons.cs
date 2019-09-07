using System;

namespace Tanks.Game
{
    [Serializable]
    public class Weapon
    {
        // weapon attribute
        public int weaponId;
        public WeaponDamage weaponDamage;
    }

    [Serializable]
    public class WeaponDamage
    {
        public int damage;
    }
}