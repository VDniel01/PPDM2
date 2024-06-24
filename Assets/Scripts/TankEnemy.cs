using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : MonoBehaviour
{
    public int damage = 30;
    public int health = 100;
    public int scoreValue = 30;
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController>().TakeDamage(damage);
            ReturnToPool();
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            scoreManager.AddScore(scoreValue);
            ReturnToPool();
        }
    }

    void ReturnToPool()
    {
        gameObject.SetActive(false); // Desactiva el objeto en lugar de destruirlo
    }
}


