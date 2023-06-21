using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab; // �߻��� �Ѿ��� ������

    private void Update()
    {
        // ���콺 ���� ��ư�� Ŭ������ �� �Ѿ� �߻�
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        // �Ѿ� �߻�
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}

