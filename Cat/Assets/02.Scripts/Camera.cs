using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera : MonoBehaviour
{


    public float speedRate; // ���ǵ� �ӵ��� ���� �ϱ� ���Ѻ��� 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedRate * Time.deltaTime * 0f, 0, 0);
        gameObject.transform.position += new Vector3(1f, 0.0f, 0.0f);
    }

}
