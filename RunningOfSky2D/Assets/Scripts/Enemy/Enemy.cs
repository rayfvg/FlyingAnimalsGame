using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] int _damage;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Player.Player player))
                player.ApplyDamage(_damage);

            Die();
        }
        private void Die() => gameObject.SetActive(false); 
    }
}