using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private bool smooth;
    [SerializeField, Range(0, 1)] private float smoothSpeed = 0.125f;
    private void FixedUpdate()
    {
        if (!smooth) transform.position = target.position + offset;
        else
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
        transform.LookAt(target);
    }
}