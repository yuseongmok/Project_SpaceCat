using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossController : MonoBehaviour
{
    public int maxHealth = 1000; // 보스의 최대 체력
    public int currentHealth; // 보스의 현재 체력

    public Slider healthBar; // HP 바 UI

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(20);
            Destroy(collision.gameObject);
            Debug.Log("공격에 맞음");
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            // 보스가 죽었을 때의 동작 처리
            Die();
        }
    }

    private void Die()
    {
        // 보스가 죽었을 때의 동작 처리
        Destroy(gameObject);
    }
}


