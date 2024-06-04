using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject[] _enemyPrefabs;
    [SerializeField] private float _timeBetweenSpawn;
    [SerializeField] private Transform[] _spawnerPosition;

    private float _time;

    private void Start() => Initialize(_enemyPrefabs);

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