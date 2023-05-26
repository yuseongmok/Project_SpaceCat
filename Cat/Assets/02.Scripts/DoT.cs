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
        transform.DOMoveX(-2500, 30);                            //물체가 X방향으로 5마큼 2초 동안 가겠다.

        sequence = DOTween.Sequence();                  
    }

    // Update is called once per frame
    void Update()
    {

    }
}
