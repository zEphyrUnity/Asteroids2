using UnityEngine;


namespace Asteroids
{
    public class ShipDestroyer : IDestroy
    {
        public void Destroyer(float hitPoints, GameObject ship)
        {
            if (hitPoints <= 0)
            {
                GameObject.Destroy(ship);
            }
            else
            {
                hitPoints--;
            }
        }
    }
}