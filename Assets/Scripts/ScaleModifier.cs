using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleModifier : MonoBehaviour
{
    public Transform detectionPoint;

    private const float detectionRadius = 0.2f;

    public LayerMask detectionLayer;

    public float scaleSpeed = 1f;

    bool Scale = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DetectObject())
        {
            if(InteractInput())
            {
                Debug.Log("Interact");
                Scale = true;
            }
        }
    

    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    bool DetectObject()
    {
        return Physics2D.OverlapCircle(detectionPoint.position,detectionRadius,detectionLayer);
    }


    if (Scale == true)
        {

            if (Input.GetKey (KeyCode.C))

            transform.localScale = new Vector3 (0.5f * scaleSpeed, 0.5f * scaleSpeed, 0);

            if (Input.GetKey (KeyCode.V))

            transform.localScale = new Vector3 (1f * scaleSpeed, 1f * scaleSpeed, 0);
    }
    }
}