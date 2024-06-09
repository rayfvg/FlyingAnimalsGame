using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _scoreCoinText;
    [SerializeField] private TMP_Text _scoreRecordText;
    [SerializeField] public float _speedGetScore;
    private float _time;
    [SerializeField] public static int Money;
    [SerializeField] public static int OldMoney = 1;

    public int ScoreUp;

    private void Start()
    {
        Money = PlayerPrefs.GetInt("Money");
        OldMoney = PlayerPrefs.GetInt("OldMoney");
        

        if (Money > OldMoney)
        {
            OldMoney = Money;
            PlayerPrefs.SetInt("OldMoney", OldMoney);
            _scoreRecordText.text = PlayerPrefs.GetInt("Money").ToString();
            YandexGame.NewLeaderboardScores("Score", Money);
        }
        else
        {
            _scoreRecordText.text = PlayerPrefs.GetInt("OldMoney").ToString();
        }
       
        

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
        }

        PlayerPrefs.SetInt("Money", Money);
        _scoreText.text = Money.ToString();
        _scoreCoinText.text = Coin.Coins.ToString();



    }
}