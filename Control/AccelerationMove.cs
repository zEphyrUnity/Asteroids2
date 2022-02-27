using UnityEngine;

namespace Asteroids
{
    internal sealed class AccelerationMove : MovePhysics
    {
        private readonly float _acceleration;

        public AccelerationMove(Transform transform, float speed, float acceleration) : base(transform, speed)
        {
            _acceleration = acceleration;
        }

        public void AddAcceleration()
        {
            Speed += _acceleration;
        }

        public void RemoveAcceleration()
        {
            Speed -= _acceleration;
        }
    }
}