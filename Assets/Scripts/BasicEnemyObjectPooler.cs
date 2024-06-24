using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyObjectPooler : MonoBehaviour
{
    public GameObject basicEnemyPrefab; // Asigna el prefab del enemigo básico en el inspector
    public int poolSize = 20;
    private List<GameObject> pool;

    void Start()
    {
        pool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(basicEnemyPrefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        GameObject newObj = Instantiate(basicEnemyPrefab);
        newObj.SetActive(true);
        pool.Add(newObj);
        return newObj;
    }
}
