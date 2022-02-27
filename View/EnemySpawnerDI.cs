using UnityEngine;


namespace Asteroids
{
    public class EnemySpawnerDI
    {
        private readonly IEnemySpawner _enemySpawnerImplementation;

        public EnemySpawnerDI(IEnemySpawner enemySpawnerImplementation)
        {
            _enemySpawnerImplementation = enemySpawnerImplementation;
        }

        public void Exclaim(Vector2 spawnPosition, int quantity, Rigidbody2D enemy)
        {
            _enemySpawnerImplementation.Spawn(spawnPosition, quantity, enemy);
        }
    }
}