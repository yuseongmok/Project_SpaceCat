using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public string nextSceneName; // �̵��� ���� Scene�� �̸�

    public void OnButtonClick()
    {
        SceneManager.LoadScene(nextSceneName); // ���� Scene���� ��ȯ
    }
}
