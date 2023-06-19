using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float moveSpeed = 5f;
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
        float moveX = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveX, 0f) * moveSpeed;
        rb.velocity = new Vector2(movement.x, rb.velocity.y);

       

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
