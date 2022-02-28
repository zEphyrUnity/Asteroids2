using UnityEngine;

namespace Asteroids
{
    public interface IKeyManager
    {
        void MovementControl(Ship ship, Rigidbody2D shipRb, float deltaTime);
    }   
}
