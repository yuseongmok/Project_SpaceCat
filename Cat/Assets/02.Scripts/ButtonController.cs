using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public string nextSceneName; // 이동할 다음 Scene의 이름

    public void OnButtonClick()
    {
        SceneManager.LoadScene(nextSceneName); // 다음 Scene으로 전환
    }
}
