using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject[] _enemyPrefabs;
    [SerializeField] private GameObject _coinPrefabs;

    [SerializeField] private float _timeBetweenSpawn;
    [SerializeField] private Transform[] _spawnerPosition;

    private float _time;

    private void Start()
    {
        Initialize(_enemyPrefabs);
        Initialize(_coinPrefabs);
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _timeBetweenSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
            _time = 0;

            int RandomPositionSpawn = Random.Range(0, _spawnerPosition.Length);
            SetEnemy(enemy, _spawnerPosition[RandomPositionSpawn].position);
            }
        }
    }

    private void SetEnemy (GameObject enemy, Vector3 spawnPosition)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPosition;
    }
}