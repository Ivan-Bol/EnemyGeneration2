using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Purpose _purpose;

    public void SpawnEnemy()
    {
        Enemy enemy = Instantiate(_enemyPrefab);
        enemy.Initialize(transform.position, _purpose.transform);
    }
}