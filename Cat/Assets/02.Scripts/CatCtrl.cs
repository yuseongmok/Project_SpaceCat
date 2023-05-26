using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCtrl : MonoBehaviour
{


    public float jumpForce = 8;
    public LayerMask isGround;
    private Rigidbody2D rb;
    public bool jump1,junmp2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector2.down * 10f);
        float timer = 0.1f;
        if (jump1 == false)
        {
            if (Physics2D.Raycast(transform.position, Vector2.down, 10f, isGround) && Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity += Vector2.up * jumpForce;
                jump1 = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity += Vector2.up * jumpForce;
                jump1 = false;
            }
        }
        if(jump1 == true)
        {
            timer -= Time.deltaTime;
        }
        if(timer <= 0)
        {
            jump1 = true;
        }

    }
}
