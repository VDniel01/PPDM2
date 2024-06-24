using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public EnemySpawner enemySpawner;

    void Start()
    {
        SpawnBasicEnemy(); // Llama al m�todo correcto aqu�
    }

    void SpawnBasicEnemy()
    {
        GameObject basicEnemy = enemySpawner.basicEnemyPooler.GetPooledObject();
        if (basicEnemy != null)
        {
            basicEnemy.transform.position = GetRandomSpawnPosition();
            basicEnemy.SetActive(true);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        // Genera una posici�n aleatoria alrededor del �rea de juego
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, 10f);
        return new Vector3(x, y, 0);
    }
}