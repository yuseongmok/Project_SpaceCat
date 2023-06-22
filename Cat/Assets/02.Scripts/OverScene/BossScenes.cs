using UnityEngine;
using UnityEngine.SceneManagement;

public class BossScenes : MonoBehaviour
{
    public string nextScene; // ��ȯ�� ���� ���� �̸�

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // �÷��̾� ������Ʈ�� �浹�ϸ�
        {
            SceneManager.LoadScene(nextScene); // ���� ������ ��ȯ
        }
    }
}
