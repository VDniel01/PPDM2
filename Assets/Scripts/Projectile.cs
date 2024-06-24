using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform target; // El objetivo al que se dirige el proyectil

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    void Update()
    {
        if (target != null)
        {
            // Lógica para mover el proyectil hacia el objetivo (ejemplo)
            transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * 10f);

            // Si alcanza el objetivo, destruye el proyectil (ejemplo)
            if (transform.position == target.position)
            {
                Destroy(gameObject);
            }
        }
    }
}
