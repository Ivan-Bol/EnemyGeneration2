using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private int _spawmTime;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private void Spawn()
    {
        if (_spawnPoints.Count > 0)
        {
            int number = Random.Range(0, _spawnPoints.Count);
            _spawnPoints[number].SpawnEnemy();
        }
    }

    private IEnumerator SpawnEnemies()
    {
        var wait = new WaitForSeconds(_spawmTime);
        bool isWork = true;

        while (isWork)
        {
            yield return wait;

            Spawn();
        }
    }
}