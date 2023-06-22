using UnityEngine;

public class MonsterSpead : MonoBehaviour
{
    private bool playerApproaching = false;
    private Rigidbody2D rb;
    public float distance;
    public GameObject Player;

    public float moveSpeed = 20.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        // 플레이어와 몬스터 사이의 거리를 계산
        distance = Vector2.Distance(transform.position, Player.transform.position);

        // 플레이어가 공격 범위 내에 있으면 이동
        if (distance <= 110.0f)
        {
            MoveForward();
        }
    }

    private void MoveForward()
    {
        this.gameObject.transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0.0f, 0.0f);
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
