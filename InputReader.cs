using System;
using UnityEngine;


namespace Asteroids
{
    public class InputReader
    {
        private readonly IKeyManager _keyManagerImplementation;

        public InputReader(IKeyManager keyManagerImplementation)
        {
            _keyManagerImplementation = keyManagerImplementation ?? 
                throw new ArgumentNullException("keyManagerImplementation == null!");
        }

        public void Exclaim(Ship ship, Rigidbody2D shipRb, float deltaTime)
        {
            _keyManagerImplementation.MovementControl(ship, shipRb, deltaTime);
        }
    }
}