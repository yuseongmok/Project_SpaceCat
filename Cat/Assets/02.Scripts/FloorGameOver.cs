using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorGameOver : MonoBehaviour
{
    public string sceneName; // 전환할 씬의 이름
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor2")) // 바닥과 충돌한 경우
        {
            SceneManager.LoadScene(sceneName); // 씬 전환
        }
    }
}
