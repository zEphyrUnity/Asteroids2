using UnityEngine;

namespace Asteroids
{
    public interface ICombatControl
    {
        void Combat(Rigidbody2D bullet, Transform barrel, float force);
    }
}