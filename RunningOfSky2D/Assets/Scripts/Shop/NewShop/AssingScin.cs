using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssingScin : MonoBehaviour
{
    public Sprite[] skins;

    public GameObject Player;

    private void Start()
    {
        Player.GetComponent<SpriteRenderer>().sprite = skins[PlayerPrefs.GetInt("skinNum")];
    }
}
