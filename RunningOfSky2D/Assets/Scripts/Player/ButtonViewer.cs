using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class ButtonViewer : MonoBehaviour
{
    public Button UpButton;
    public Button DownButton;
    public Player.PlayerMover _mover;

    private void Start()
    {
        if (YG.YandexGame.EnvironmentData.deviceType == "mobile")
        {
            UpButton.gameObject.SetActive(true);
            DownButton.gameObject.SetActive(true);
        }
        else
        {
            UpButton.gameObject.SetActive(false);
            DownButton.gameObject.SetActive(false);

        }
    }
}

