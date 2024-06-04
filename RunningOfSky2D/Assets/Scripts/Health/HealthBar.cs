using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player.Player _player;
    [SerializeField] private Heart _heartPrefab;

    private List<Heart> _heart = new List<Heart>();

    private void OnEnable() => _player.HealthChanged += OnHealthChanged;

    private void OnDisable() => _player.HealthChanged -= OnHealthChanged;

    private void OnHealthChanged(int value)
    {
        if (_heart.Count < value)
        {
            int creatHealth = value - _heart.Count;
            for (int i = 0; i < creatHealth; i++)
                CreateHeart();
        }
        else if (_heart.Count > value && _heart.Count != 0)
        {
            int deleteHealt = _heart.Count - value;
            for (int i = 0; i < deleteHealt; i++)
                DestroyHeart(_heart[_heart.Count - 1]);
        }
    }

    private void DestroyHeart(Heart heart)
    {
        _heart.Remove(heart);
        heart.ToEmpty();
    }

    private void CreateHeart()
    {
        Heart newHeatr = Instantiate(_heartPrefab, transform);
        _heart.Add(newHeatr.GetComponent<Heart>());
        newHeatr.ToFill();
    }
}