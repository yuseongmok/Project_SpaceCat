using UnityEngine;

public class MonsterSpead : MonoBehaviour
{
    private bool playerApproaching = false;
    private Rigidbody2D rb;
    public float distance;
    public GameObject Player;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        // �÷��̾�� ���� ������ �Ÿ��� ���
        distance = Vector2.Distance(transform.position, Player.transform.position);

        // �÷��̾ ���� ���� ���� ������ �̵�
        if (distance <= 110.0f)
        {
            MoveForward();
        }
    }

    private void MoveForward()
    {
        Debug.Log("----------");
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
