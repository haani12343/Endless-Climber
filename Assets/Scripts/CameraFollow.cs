using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float topThreshold = 3f;
    public float smoothSpeed = 5f;
    void LateUpdate()
    {
        float targetY = transform.position.y;
        if (player.position.y > transform.position.y + topThreshold)
        {
            targetY = player.position.y - topThreshold;
        }
        Vector3 targetPosition = new Vector3(
            transform.position.x,
            targetY,
            transform.position.z
        );
        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );
    }
}