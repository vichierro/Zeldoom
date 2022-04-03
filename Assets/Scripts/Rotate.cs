using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float speed = 2f;

    private void Update()
    {
        transform.Rotate(0, 0, 90 * speed * Time.deltaTime);    
    }
}
