using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    private void LateUpdate()
    {
        if (transform.position.x > -10)
            return;

        transform.Translate(0, 0, 0, Space.Self);
    }
}
