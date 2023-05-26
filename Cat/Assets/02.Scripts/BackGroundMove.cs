using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{

    
    public float speedRate; // 스피드 속도를 조절 하기 위한변수 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()   //무한루프
    {
        if (transform.position.x < -300)    //이 오브젝트의 X 좌표가 -258 이하로 떨어지면
        {
            gameObject.transform.position += new Vector3(600.0f, 0.0f, 0.0f);           // 오른쪽으로 2칸 크기 만큼 이동
        }

        //gameObject.transform.position += new Vector3(-speedRate * Time.deltaTime * 1f, 0.0f, 0.0f);

        transform.Translate(-speedRate * Time.deltaTime * 1f, 0, 0);                    // 일정 시간동안 왼쪽으로 오브젝트 이동 시킨다.
    }
}
