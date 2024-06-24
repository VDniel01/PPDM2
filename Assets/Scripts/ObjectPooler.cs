using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour
{
    public GameObject objectPrefab; // Asegúrate de asignar este en el Inspector
    public int poolSize = 10;

    private List<GameObject> pooledObjects = new List<GameObject>();

    void Start()
    {
        // Crear y almacenar instancias del objeto en la pool
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    // Método para obtener un objeto de la pool
    public GameObject GetPooledObject()
    {
        // Buscar un objeto inactivo en la pool y devolverlo
        foreach (GameObject obj in pooledObjects)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        // Si no hay objetos disponibles en la pool, devolver null
        return null;
    }
}
