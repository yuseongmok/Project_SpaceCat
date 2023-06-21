using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossController : MonoBehaviour
{
    public int maxHealth = 1000; // ������ �ִ� ü��
    public int currentHealth; // ������ ���� ü��

    public Slider healthBar; // HP �� UI

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
            Debug.Log("���ݿ� ����");
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            // ������ �׾��� ���� ���� ó��
            Die();
        }
    }

    private void Die()
    {
        // ������ �׾��� ���� ���� ó��
        Destroy(gameObject);
    }
}


