using UnityEngine;

public class MonsterJump : MonoBehaviour
{
    private bool playerApproaching = false;
    private bool isJumping = false;
    private float jumpForce = 100f;
    private Rigidbody2D rb;
    public float distance;
    public GameObject Player;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindWithTag("Player");
        isJumping = false;
    }

    private void Update()
    {
        {

            // �÷��̾�� ���� ������ �Ÿ��� ���
            distance = Vector2.Distance(transform.position, Player.transform.position);

            // �÷��̾ ���� ���� ���� ������ ����
            if (distance <= 110.0f)
            {
                if (isJumping == false)
                {
                    Jump();
                }
            }


        }

    }

    private void Jump()
    {
        isJumping = true;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        Invoke(nameof(ResetJump), 1.5f);
    }

    private void ResetJump()
    {
        isJumping = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerApproaching = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerApproaching = false;
        }
    }
}
