using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public int damage = 20; // 총알의 데미지
    public float bulletSpeed = 10f; // 총알의 속도

    private void Start()
    {
        Destroy(gameObject, 1f); // 1초 후에 총알을 파괴
    }

    private void Update()
    {
        // 총알을 x축으로 이동
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
    }
}

