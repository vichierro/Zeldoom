using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleModifier : MonoBehaviour
{

    public float scaleSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.C))

            transform.localScale = new Vector3 (0.5f * scaleSpeed, 0.5f * scaleSpeed, 0);

        if (Input.GetKey (KeyCode.V))

            transform.localScale = new Vector3 (1f * scaleSpeed, 1f * scaleSpeed, 0);
    }
}
