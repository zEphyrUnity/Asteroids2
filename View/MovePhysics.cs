using UnityEngine;


namespace Asteroids
{
    internal class MovePhysics : IMove
    {
        private readonly Transform _transform;
        private Vector3 _move;

        public float Speed { get; protected set; }
        
        public MovePhysics(Transform transform, float speed)
        {
            _transform = transform;
            Speed = speed;
        }

        public void Move(Rigidbody2D ship, float deltaTime, Vector2 moveAxis)
        {
            ship.AddForce(moveAxis * Speed * deltaTime);
        }
    }
}