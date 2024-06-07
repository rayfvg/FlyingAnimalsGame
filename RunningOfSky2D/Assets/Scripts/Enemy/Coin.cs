using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] static public int Coins;
    [SerializeField] private TMP_Text _textCoin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player.Player>())
        {
            Coins += 5;
            PlayerPrefs.SetInt("Coin", Coins);
           
        }
    }
}
