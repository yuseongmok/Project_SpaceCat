using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; // ���� ��
    public int maxJumpCount = 2; // �ִ� ���� Ƚ��
    private int jumpCount = 0; // ���� ���� Ƚ��
    public float fallMultiplier = 2.5f; // �߷� ������

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // ���� ��ư�� ������ ��
        if (Input.GetButtonDown("Jump"))
        {
            // ���� ���� Ƚ���� �ִ� ���� Ƚ������ ���� ��쿡�� ���� ����
            if (jumpCount < maxJumpCount)
            {
                Jump();
                jumpCount++;
            }
        }

        // ���� ���� ��� �߰� �߷��� ����
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �ٴڿ� ����� �� ���� Ƚ�� �ʱ�ȭ
        if (collision.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }
}
