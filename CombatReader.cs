using System;
using UnityEngine;


namespace Asteroids
{
    public class CombatReader
    {
        private readonly  ICombatControl _combatControlImplementation;
        
        public CombatReader(ICombatControl combatControlImplementation)
        {
            _combatControlImplementation = combatControlImplementation ??
                throw new ArgumentNullException("combatControlImplementation == null!");
        }

        public void Exclaim(Rigidbody2D bullet, Transform barrel, float force)
        {
            _combatControlImplementation.Combat(bullet, barrel, force);
        }
    }
}