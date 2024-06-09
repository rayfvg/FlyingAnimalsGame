using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class ADSforButton : MonoBehaviour
{
    public Player.Player player;
    public Button ButtonForADS;

    

    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // ������������ �� ������� �������� ������� � OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    // ����������� ����� ��������� �������
    void Rewarded(int id)
    {
    
            player.AddMoneyForAds();
    }

    // ����� ��� ������ ����� �������
    public void ExampleOpenRewardAd(int id)
    {
        // �������� ����� �������� ����� �������
        YandexGame.RewVideoShow(id);
    }
}
