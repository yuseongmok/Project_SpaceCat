using UnityEngine;
using UnityEngine.SceneManagement;

public class BossScenes : MonoBehaviour
{
    public string nextScene; // 전환할 다음 씬의 이름

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // 플레이어 오브젝트와 충돌하면
        {
            SceneManager.LoadScene(nextScene); // 다음 씬으로 전환
        }
    }
}
