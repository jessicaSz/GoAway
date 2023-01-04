using System;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnPoint;
    [SerializeField] private GameObject _enemy;

    private void Start()
    {
        SpawnEnemies(1);
    }

    private void SpawnEnemies(int numberOfEnemies)
    {
        for (int i = 1; i <= numberOfEnemies; i++)
        {
            var enemy = Instantiate(_enemy);
            enemy.transform.SetParent(_spawnPoint.transform);
            enemy.transform.position = _spawnPoint.transform.position;
        }
    }
}
