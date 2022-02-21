using UnityEngine;


namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float acceleration;
        [SerializeField] private float hp;
        [SerializeField] private Rigidbody2D bullet;
        [SerializeField] private Rigidbody2D shipRb;
        [SerializeField] private Transform barrel;
        [SerializeField] private float force;
        
        private readonly IDestroy _shipDestroyer = new ShipDestroyer();
        private Camera _camera;
        private Ship _ship;
        private Annihilator _annihilator;
        private InputReader _inputReader;
        private CombatReader _combatReader;
        
        private void Start()
        {
            _camera = Camera.main;

            var movePhysicsImplementation = new MovePhysics(transform, speed);
            var rotationImplementation = new RotationShip(transform);
            var keyManagerImplementation = gameObject.AddComponent<KeyManager>();
            var combatControlImplementation = gameObject.AddComponent<CombatControl>();
            
            _inputReader = new InputReader(keyManagerImplementation);
            _ship = new Ship(movePhysicsImplementation, rotationImplementation);
            _annihilator = new Annihilator(_shipDestroyer);
            _combatReader = new CombatReader(combatControlImplementation);
        }

        private void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            
            _ship.Rotation(direction);
           
            _inputReader.Exclaim(_ship, shipRb, Time.deltaTime);
            _combatReader.Exclaim(bullet, barrel, force);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _annihilator.Exclaim(hp, gameObject);
        }
    }
}