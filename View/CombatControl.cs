using UnityEngine;


namespace Asteroids
{
    public class CombatControl : MonoBehaviour, ICombatControl
    {
        public void Combat(Rigidbody2D bullet, Transform barrel, float force)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                var temAmmunition = Instantiate(bullet, barrel.position, barrel.rotation);
                temAmmunition.AddForce(barrel.up * force);
            }
        }
    }
}