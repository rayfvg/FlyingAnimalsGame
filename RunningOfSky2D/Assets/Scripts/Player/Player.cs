using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int _health;
        public event UnityAction<int> HealthChanged;
        public event UnityAction PlayerDead;
        

        private void Start() => HealthChanged?.Invoke(_health);

        public void ApplyDamage(int damage)
        {
            _health -= damage;
            HealthChanged?.Invoke(_health);
            if (_health <= 0)
                Invoke("Die", 0.4f);
        }

        public void Die() => PlayerDead?.Invoke();
    }
}