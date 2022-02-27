using System;
using UnityEngine;


namespace Asteroids
{
    public class Annihilator
    {
        private IDestroy _destroyMethod;
        
        internal Annihilator(IDestroy destroyMethod)
        {
            if(destroyMethod == null)
                throw new ArgumentNullException("---> destroyMethod == null !");

            _destroyMethod = destroyMethod;
        }

        internal void Exclaim(float hitPoints, GameObject ship)
        {
            _destroyMethod.Destroyer(hitPoints, ship);
        }
    }
}