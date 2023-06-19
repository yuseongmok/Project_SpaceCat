using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int health = 100;  // 몬스터의 초기 체력

    public void TakeDamage(int damage)
    {
        health -= damage;  // 총알에 맞은 만큼 체력 감소

        if (health <= 50)
        {
            Destroy(gameObject);  // 체력이 0 이하이면 몬스터를 파괴
        }
    }
}
