using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text scoreText; // 점수를 표시할 UI 텍스트
    private int score = 0; // 현재 점수

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            // 코인을 먹었을 때 점수를 1000씩 증가
            score += 1000;
            UpdateScoreText();

            // 코인 오브젝트를 제거
            Destroy(collision.gameObject);
        }
    }

    private void UpdateScoreText()
    {
        // UI 텍스트 업데이트
        scoreText.text = "" + score.ToString();
    }
}
