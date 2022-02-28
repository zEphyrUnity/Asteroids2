using UnityEngine;


namespace Asteroids
{
    #region class Player definition

     internal sealed class Player : MonoBehaviour
    {
        #region SerializeFields
        
        [SerializeField] private float speed;
        [SerializeField] private float acceleration;
        [SerializeField] private float hp;
        [SerializeField] private float force;
        
        [SerializeField] private Rigidbody2D bullet;
        [SerializeField] private Rigidbody2D shipRb;
        [SerializeField] private Rigidbody2D enemyAsteroid;
        [SerializeField] private Transform barrel;

        #endregion
        
        #region Fields
                         private readonly IDestroy _theDestroyer = new TheDestroyer();
                         private readonly IEnemySpawner _enemySpawnerImplementation = new EnemySpawner();
                         
                         private Camera _camera;
                         private Ship _ship;
                         private DestroyDI _destroyDi;
                         private InputReader _inputReader;
                         private CombatControlDI _combatControlDi;
                         private EnemySpawnerDI _enemySpawnerDI;
                         
        #endregion
                         
        #region UnityMethods
        
        private void Start()
        {
            _camera = Camera.main;

            var movePhysicsImplementation = new MovePhysics(transform, speed);
            var rotationImplementation = new RotationShip(transform);
            var keyManagerImplementation = gameObject.AddComponent<KeyManager>();
            var combatControlImplementation = gameObject.AddComponent<CombatControl>();
            
            _inputReader = new InputReader(keyManagerImplementation);
            _ship = new Ship(movePhysicsImplementation, rotationImplementation);
            _destroyDi = new DestroyDI(_theDestroyer);
            _combatControlDi = new CombatControlDI(combatControlImplementation);
            _enemySpawnerDI = new EnemySpawnerDI(_enemySpawnerImplementation);
            
            _enemySpawnerDI.Exclaim(new Vector2(1, 1), 1, enemyAsteroid);
        }

        private void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            
            _ship.Rotation(direction);
           
            _inputReader.Exclaim(_ship, shipRb, Time.deltaTime);
            _combatControlDi.Exclaim(bullet, barrel, force);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag != "Missle")
            {
                _destroyDi.Exclaim(hp, gameObject);
                _destroyDi.Exclaim(hp, other.gameObject);
            }
        }
        
        #endregion
        
    }

    #endregion
}