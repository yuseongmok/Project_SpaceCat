using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BossGameOver : MonoBehaviour
{
    public string sceneName;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LaserBeam")) // �������� �浹�� ���
        {
            SceneManager.LoadScene(sceneName); // �� ��ȯ
        }
    }
}
