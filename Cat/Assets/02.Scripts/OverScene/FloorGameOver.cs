using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorGameOver : MonoBehaviour
{
    public string sceneName; // ��ȯ�� ���� �̸�
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
        if (collision.gameObject.CompareTag("Floor2")) // �ٴڰ� �浹�� ���
        {
            SceneManager.LoadScene(sceneName); // �� ��ȯ
        }
    }
}
