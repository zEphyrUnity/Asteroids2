using UnityEngine;


namespace Asteroids
{
    public class TheDestroyer : IDestroy
    {
        public void Anihilator(float hitPoints, GameObject victim)
        {
            if (hitPoints <= 0)
            {
                GameObject.Destroy(victim);
            }
            else
            {
                hitPoints -= 20;
            }
        }
    }
} 