using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoT : MonoBehaviour
{
    public bool isPunch = false;

    Sequence sequence;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveX(-2500, 30);                            //��ü�� X�������� 5��ŭ 2�� ���� ���ڴ�.

        sequence = DOTween.Sequence();                  
    }

    // Update is called once per frame
    void Update()
    {

    }
}
