using UnityEngine;


namespace Asteroids
{
    public interface IDestroy
    {
        void Destroyer(float hitPoints, GameObject ship);
    }
}