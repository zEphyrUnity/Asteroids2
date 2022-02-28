using System;
using UnityEngine;


namespace Asteroids
{
    public class DestroyDI
    {
        private IDestroy _destroyMethod;
        
        internal DestroyDI(IDestroy destroyMethod)
        {
            if(destroyMethod == null)
                throw new ArgumentNullException("---> destroyMethod == null !");

            _destroyMethod = destroyMethod;
        }

        internal void Exclaim(float hitPoints, GameObject ship)
        {
            _destroyMethod.Anihilator(hitPoints, ship);
        }
    }
}