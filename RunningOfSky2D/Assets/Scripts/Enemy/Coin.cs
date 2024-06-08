using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] static public int Coins;
    
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player.Player player))
        {
            player.TakeCoin();
            
        }
        gameObject.SetActive(false);
    }
}
