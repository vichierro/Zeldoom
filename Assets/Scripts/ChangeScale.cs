using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{

    [Range(0.1f, 1f)]
    public float scaleSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.C))

            transform.localScale = new Vector3 (0.5f, 0.5f, 0);

        if (Input.GetKey (KeyCode.V))

            transform.localScale = new Vector3 (1f, 1f, 0);

    }
}
