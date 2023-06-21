using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int health = 100;  // ������ �ʱ� ü��

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(20);

            Debug.Log("���ݿ� ����");
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;  // �Ѿ˿� ���� ��ŭ ü�� ����

        if (health <= 50)
        {
            Destroy(gameObject);  // ü���� 0 �����̸� ���͸� �ı�
        }
    }
}
