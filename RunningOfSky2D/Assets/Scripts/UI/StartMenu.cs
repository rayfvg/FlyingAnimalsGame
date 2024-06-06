using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private GameOverScript _gameOverScript;
    [SerializeField] private StartMenu _startMenu;

    private void Start() => Time.timeScale = 0;

    public void StartGame()
    {
        Time.timeScale = 1;
        _startMenu.gameObject.SetActive(false);
    }
    public void QuitGame() => Application.Quit();

    public void SceneShop() => SceneManager.LoadScene(1);

    public void ResetAll()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
}
