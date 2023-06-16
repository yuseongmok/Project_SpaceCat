using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; // 점프 힘
    public int maxJumpCount = 2; // 최대 점프 횟수
    private int jumpCount = 0; // 현재 점프 횟수
    public float fallMultiplier = 2.5f; // 중력 증폭값

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // 점프 버튼을 눌렀을 때
        if (Input.GetButtonDown("Jump"))
        {
            // 현재 점프 횟수가 최대 점프 횟수보다 작을 경우에만 점프 가능
            if (jumpCount < maxJumpCount)
            {
                Jump();
                jumpCount++;
            }
        }

        // 점프 중인 경우 추가 중력을 적용
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
        // 바닥에 닿았을 때 점프 횟수 초기화
        if (collision.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }
}
