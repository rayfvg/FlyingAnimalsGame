using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinChanger : MonoBehaviour
{
    [SerializeField] private Player.Player _player;
    [SerializeField] private int _priceForBuy;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private Score _score;

    private SpriteRenderer _playerSkin;

    private Button _button;

    private void Awake() => _button = GetComponent<Button>();

    private void OnEnable() => _button.onClick.AddListener(ChancedSkin);

    private void OnDisable() => _button.onClick.RemoveListener(ChancedSkin);

    private void Start() => _playerSkin = _player.GetComponent<SpriteRenderer>();

    public void ChancedSkin()
    {
        if (Score.Money >= _priceForBuy)
        {
            _playerSkin.sprite = _sprite;
            Score.Money -= _priceForBuy;
        }
    }
}