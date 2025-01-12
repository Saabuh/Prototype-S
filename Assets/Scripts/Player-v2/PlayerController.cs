using Item;
using UnityEngine;

namespace Prototype_S
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] private InputReader playerInput;
        [SerializeField] private Player2 player;

        public float playerSpeed = 5.0f;

        void Start()
        {
            //initialize any necessary components
            playerInput = GetComponent<InputReader>();
            player = GetComponent<Player2>();
            
            //subscribe functions to events
            playerInput.OnFire += HandleUse;

        }

        void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector2 movement = new Vector2(playerInput.Horizontal, playerInput.Vertical);

            transform.Translate(movement * (playerSpeed * Time.deltaTime));
        }

        void HandleUse(Vector2 mousePosition)
        {
            //determine aim direction
            Vector2 direction = (mousePosition - (Vector2)player.transform.position).normalized;

            GameObject projectile =
                Instantiate(player.projectilePrefab, player.transform.position, Quaternion.identity);
            
            projectile.GetComponent<Projectile>().Initialize(direction);
        }
    }
}
