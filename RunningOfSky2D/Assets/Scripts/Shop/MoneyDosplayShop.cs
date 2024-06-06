using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyDosplayShop : MonoBehaviour
{
    public TMP_Text MoneyText;

    private void Start()
    {
        MoneyText.text = Score.Money.ToString();
    }
}
