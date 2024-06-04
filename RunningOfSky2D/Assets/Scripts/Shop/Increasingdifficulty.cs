using UnityEngine;

public class Increasingdifficulty : MonoBehaviour
{
    [SerializeField] private float _rateOfIncrease;
    private float _time;

    private void Update()
    {
        _time += Time.deltaTime * _rateOfIncrease;
        if ( _time > 1)
        {
            _time = 0;
            Time.timeScale += 0.1f;
        }
    }
}
