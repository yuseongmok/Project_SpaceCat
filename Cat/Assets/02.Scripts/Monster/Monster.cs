using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int health = 100;  // ������ �ʱ� ü��

    public void TakeDamage(int damage)
    {
        health -= damage;  // �Ѿ˿� ���� ��ŭ ü�� ����

        if (health <= 50)
        {
            Destroy(gameObject);  // ü���� 0 �����̸� ���͸� �ı�
        }
    }
}
