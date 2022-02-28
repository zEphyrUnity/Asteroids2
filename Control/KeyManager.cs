using UnityEngine;

namespace Asteroids
{
    public class KeyManager : MonoBehaviour, IKeyManager
    {
        public void MovementControl(Ship ship, Rigidbody2D shipRb, float deltaTime)
        {
            if (Input.GetKey("w"))
            {
                ship.Move(shipRb, Time.deltaTime, Vector2.up);
            }

            if (Input.GetKey("s"))
            {
                ship.Move(shipRb, Time.deltaTime, Vector2.down);
            }
            
            if (Input.GetKey("a"))
            {
                ship.Move(shipRb, Time.deltaTime, Vector2.left);
            }
            
            if (Input.GetKey("d"))
            {
                ship.Move(shipRb, Time.deltaTime, Vector2.right);
            }
            
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                ship.RemoveAcceleration();
            }
        }
    }
}