using UnityEngine;


namespace Asteroids
{
    public interface IEnemySpawner
    {
        void Spawn(Vector2 spawnPosition, int quantity, Rigidbody2D enemy);
    }
}