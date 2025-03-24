using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed;
    private void Update()
    {
        // transform.position = new Vector3(target.position.x,target.position.y, -10);
        transform.position = Vector3.Slerp(
            new Vector3(transform.position.x, transform.position.y, -10),
            new Vector3(target.position.x, target.position.y, -10),
            cameraSpeed
            );
    }
}
