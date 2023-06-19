using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera : MonoBehaviour
{


    public float speedRate; // 스피드 속도를 조절 하기 위한변수 
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
