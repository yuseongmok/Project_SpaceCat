using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterAttack : MonoBehaviour
{
    public GameObject projectilePrefab; // �߻�ü ������
    public Transform projectileSpawnPoint; // �߻�ü ���� ��ġ
    public float projectileSpeed = 0f; // �߻�ü �ӵ�
    public float fireInterval = 0f; // �߻� ����
   


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

            // �÷��̾�� ���� ������ �Ÿ��� ���
            distance = Vector2.Distance(transform.position, Player.transform.position);

            // �÷��̾ ���� ���� ���� �ְ� ���� ��ٿ��� �������� ����
            if (distance <= 110.0f)
            {
                timer = 0f;
                FireProjectile();
            }


        }

    }

    private void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);      //�Ѿ��� �����ϰ� �߻��Ѵ�. 
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();                                                        //������ �̿��ؼ� �߻��Ѵ�. 
        rb.velocity = Vector2.left * projectileSpeed;
    }


}
