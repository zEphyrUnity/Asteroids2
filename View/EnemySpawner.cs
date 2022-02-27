using UnityEngine;


namespace Asteroids
{
    public class EnemySpawner : MonoBehaviour, IEnemySpawner
    {
        public void Spawn(Vector2 spawnPosition, int quantity, Rigidbody2D enemy)
        {
            spawnPosition.x = Random.Range(-5, 5);
            spawnPosition.y = Random.Range(-5, 5);
            
            var clone = Instantiate(enemy, spawnPosition, Quaternion.identity);
            
            clone.AddForce(enemy.transform.up * Random.Range(-50.0f, 150.0f));
            clone.angularVelocity = Random.Range(-0.0f, 90.0f);
        }
    }
}