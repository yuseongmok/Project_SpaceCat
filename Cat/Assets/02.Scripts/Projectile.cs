using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    public float speed = 0f; // �߻�ü �ӵ�
    public string sceneName; // ��ȯ�� ���� �̸�


    private void Update()
    {
        // �߻�ü�� �������� �̵�
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // �÷��̾�� �浹�� ���
        {
            SceneManager.LoadScene(sceneName); // �� ��ȯ
        }
    }

}
