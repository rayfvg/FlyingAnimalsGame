using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitShop : MonoBehaviour
{
    public void QuitShopScene()
    {
        SceneManager.LoadScene(0);
    }
}
