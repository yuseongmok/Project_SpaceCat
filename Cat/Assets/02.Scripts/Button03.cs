using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button03 : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        // ��ư�� Ŭ���Ǿ��� �� ó���� ���� �ۼ�
        SceneManager.LoadScene("04.SpaceCat");
    }
}
