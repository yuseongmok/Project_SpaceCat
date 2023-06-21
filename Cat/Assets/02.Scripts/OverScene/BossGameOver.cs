using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BossGameOver : MonoBehaviour
{
    public string sceneName;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LaserBeam")) // 몬스터한태 충돌한 경우
        {
            SceneManager.LoadScene(sceneName); // 씬 전환
        }
    }
}
