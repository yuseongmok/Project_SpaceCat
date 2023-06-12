using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 1.0f;

    public void Start()
    {
        Destroy(this.gameObject, 1.5f);
    }

    private void Update()
    {
        this.gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);


    }
}
