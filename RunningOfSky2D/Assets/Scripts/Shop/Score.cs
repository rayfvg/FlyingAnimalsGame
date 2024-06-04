using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _scoreTextInShop;

    [SerializeField] private float _speedGetScore;
    private float _time;
    public int Count;
 

    private void Awake()
    {
        Count += PlayerPrefs.GetInt("Money"); 
    }
   
    private void Update()
    {
        _time += Time.deltaTime * _speedGetScore;
        if (_time > 1)
        {
            Count++;
            _time = 0;
        }
        PlayerPrefs.SetInt("Money", Count);
        _scoreText.text = Count.ToString();
        _scoreTextInShop.text = Count.ToString();
    }

    public void ResetScore() => PlayerPrefs.DeleteKey("Money");
}