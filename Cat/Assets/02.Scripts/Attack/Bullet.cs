using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 1.0f;

    public void Start()
    {
        Destroy(this.gameObject, 1.1f);
    }

    public int damage = 20;  // �Ѿ��� ���ݷ�

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            Monster monster = collision.gameObject.GetComponent<Monster>();
            if (monster != null)
            {
                monster.TakeDamage(damage);  // �浹�� ��ü�� ������ ��� �ǰ� ó��
            }

            Destroy(gameObject);  // �Ѿ� �ı�
        }
    }

    private void Update()
    {
        this.gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);


    }
}
