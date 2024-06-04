using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class GameOverScript : MonoBehaviour
{
    [SerializeField] private Player.Player _player;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;

    private CanvasGroup _gameOverPanelGroup;

    private void OnEnable()
    {
        _player.PlayerDead += OnDied;
        _restartButton.onClick.AddListener(OnRestartClick);
        
    }

    private void OnDisable()
    {
        _player.PlayerDead += OnDied;
        _restartButton.onClick.RemoveListener(OnRestartClick);
       
    }

    private void Start()
    {
        _gameOverPanelGroup = GetComponent<CanvasGroup>();
        _gameOverPanelGroup.alpha = 0;
        _restartButton.enabled = false;
        
    }

    private void OnDied()
    {
        _gameOverPanelGroup.alpha = 1;
        _restartButton.enabled = true;
        
        Time.timeScale = 0;
    }

    private void OnRestartClick()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        _restartButton.enabled = false;
       
    }
    private void OnExitClick() => Application.Quit();
}