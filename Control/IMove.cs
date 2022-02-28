using UnityEngine;

namespace Asteroids
{
    public interface IMove
    {
        float Speed { get; }
        void Move(Rigidbody2D ship, float deltaTime, Vector2 moveAxis);
    }
}