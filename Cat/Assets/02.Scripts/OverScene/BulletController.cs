using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public int damage = 20; // �Ѿ��� ������
    public float bulletSpeed = 10f; // �Ѿ��� �ӵ�

    private void Start()
    {
        Destroy(gameObject, 1f); // 1�� �Ŀ� �Ѿ��� �ı�
    }

    private void Update()
    {
        // �Ѿ��� x������ �̵�
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
    }
}

