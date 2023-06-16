using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    public float speed = 0f; // 발사체 속도
    public string sceneName; // 전환할 씬의 이름


    private void Update()
    {
        // 발사체를 왼쪽으로 이동
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 플레이어와 충돌한 경우
        {
            SceneManager.LoadScene(sceneName); // 씬 전환
        }
    }

}
