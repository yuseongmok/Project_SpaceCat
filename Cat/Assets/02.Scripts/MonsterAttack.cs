using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterAttack : MonoBehaviour
{
    public GameObject projectilePrefab; // 발사체 프리팹
    public Transform projectileSpawnPoint; // 발사체 생성 위치
    public float projectileSpeed = 0f; // 발사체 속도
    public float fireInterval = 0f; // 발사 간격
   


    private float timer = 0f;

    public GameObject Player;
    public float distance;

    public void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

   

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireInterval)
        {

            // 플레이어와 몬스터 사이의 거리를 계산
            distance = Vector2.Distance(transform.position, Player.transform.position);

            // 플레이어가 공격 범위 내에 있고 공격 쿨다운이 지났으면 공격
            if (distance <= 110.0f)
            {
                timer = 0f;
                FireProjectile();
            }


        }

    }

    private void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);      //총알을 생성하고 발사한다. 
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();                                                        //물리를 이용해서 발사한다. 
        rb.velocity = Vector2.left * projectileSpeed;
    }


}
