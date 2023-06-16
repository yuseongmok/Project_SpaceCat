using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterJump : MonoBehaviour
{
    private float timer = 0f;

    public GameObject Player;
    public float distance;

    public void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }
}
