
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;


    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
