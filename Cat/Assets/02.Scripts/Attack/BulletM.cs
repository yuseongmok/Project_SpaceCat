using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletM : MonoBehaviour
{

    public GameObject cat;
    public float speed = 0.2f;

    public void Start()
    {
        cat = this.gameObject;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cat.GetComponent<Cat>().Fire();
        }
    }
}
