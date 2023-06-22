using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab; // �߻��� �Ѿ��� ������
    public AudioClip clickSound;
    public GameObject mainCamera;
    public AudioSource audioSource;


    private void Update()
    {
        // ���콺 ���� ��ư�� Ŭ������ �� �Ѿ� �߻�
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
            audioSource.PlayOneShot(clickSound);
        }
    }

    private void FireBullet()
    {
        // �Ѿ� �߻�
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}

