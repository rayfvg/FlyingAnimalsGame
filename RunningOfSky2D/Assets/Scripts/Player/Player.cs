using UnityEngine;
using UnityEngine.Events;

namespace Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private AudioSource _audioSourceCoin;
        public event UnityAction<int> HealthChanged;
        public event UnityAction PlayerDead;
        
        

        private void Start() => HealthChanged?.Invoke(_health);

        public void ApplyDamage(int damage)
        {
            _health -= damage;
            _audioSource.Play();
            HealthChanged?.Invoke(_health);
            if (_health <= 0)
                Invoke("Die", 0.4f);
        }
      
        public void TakeCoin()
        {
            Coin.Coins += 5;
            PlayerPrefs.SetInt("Coin", Coin.Coins);
            _audioSourceCoin.Play();
        }

        public void Die() => PlayerDead?.Invoke();
    }
}