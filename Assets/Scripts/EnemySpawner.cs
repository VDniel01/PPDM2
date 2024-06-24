using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public BasicEnemyObjectPooler basicEnemyPooler;

    void Start()
    {
        InvokeRepeating("SpawnEnemies", 1f, 2f); // Ejemplo: Spawnea enemigos cada 2 segundos
    }

    void SpawnEnemies()
    {
        SpawnBasicEnemy();
    }

    void SpawnBasicEnemy()
    {
        GameObject basicEnemy = basicEnemyPooler.GetPooledObject();
        if (basicEnemy != null)
        {
            basicEnemy.transform.position = GetRandomSpawnPosition();
            basicEnemy.SetActive(true);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        // Genera una posición aleatoria alrededor del área de juego
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, 10f);
        return new Vector3(x, y, 0);
    }
}
