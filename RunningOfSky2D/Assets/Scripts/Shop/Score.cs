using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _scoreCoinText;
    [SerializeField] private TMP_Text _scoreRecordText;
    [SerializeField] public float _speedGetScore;
    private float _time;
    [SerializeField] public static int Money;

    public int ScoreUp;

    private void Start()
    {
        Money = 0;
        Coin.Coins = PlayerPrefs.GetInt("Coin");
        ScoreUp = PlayerPrefs.GetInt("ScoreUpSpeed");
    }
    private void Update()
    {
        _time += Time.deltaTime * _speedGetScore;
        if (_time > 1)
        {
            Money = Money + 1 + ScoreUp;
            _time = 0;
           PlayerPrefs.SetInt("Money", Money);
        }
        _scoreText.text = Money.ToString();
        _scoreCoinText.text = Coin.Coins.ToString();
        _scoreRecordText.text = PlayerPrefs.GetInt("Money").ToString();
    }
}