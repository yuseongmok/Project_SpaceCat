using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{

    
    public float speedRate; // ���ǵ� �ӵ��� ���� �ϱ� ���Ѻ��� 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()   //���ѷ���
    {
        //gameObject.transform.position += new Vector3(-speedRate * Time.deltaTime * 1f, 0.0f, 0.0f);

        transform.Translate(-speedRate * Time.deltaTime * 1f, 0, 0);                    // ���� �ð����� �������� ������Ʈ �̵� ��Ų��.
    }
}
