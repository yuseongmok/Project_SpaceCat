using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text scoreText; // ������ ǥ���� UI �ؽ�Ʈ
    private int score = 0; // ���� ����

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            // ������ �Ծ��� �� ������ 1000�� ����
            score += 1000;
            UpdateScoreText();

            // ���� ������Ʈ�� ����
            Destroy(collision.gameObject);
        }
    }

    private void UpdateScoreText()
    {
        // UI �ؽ�Ʈ ������Ʈ
        scoreText.text = "" + score.ToString();
    }
}
