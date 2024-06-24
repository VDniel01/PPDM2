using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAttack : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefab del proyectil que se dispara

    void Start()
    {
        // Ejemplo de cómo disparar el proyectil y establecer un objetivo
        Transform target = GameObject.FindGameObjectWithTag("Player").transform; // Ejemplo de encontrar al jugador como objetivo
        ShootProjectile(target);
    }

    void ShootProjectile(Transform target)
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Projectile projectileScript = projectile.GetComponent<Projectile>();
        if (projectileScript != null)
        {
            projectileScript.SetTarget(target);
        }
        else
        {
            Debug.LogError("No se encontró el componente Projectile en el prefab del proyectil.");
        }
    }
}


