using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab; // 발사할 총알의 프리팹
    public AudioClip clickSound;
    public GameObject mainCamera;
    public AudioSource audioSource;


    private void Update()
    {
        // 마우스 왼쪽 버튼을 클릭했을 때 총알 발사
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
            audioSource.PlayOneShot(clickSound);
        }
    }

    private void FireBullet()
    {
        // 총알 발사
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}

