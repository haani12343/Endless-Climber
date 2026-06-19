using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float offsetY = 2f;
    void LateUpdate()
    {
        if (player == null) return;
        float targetY = player.position.y + offsetY;
        if (targetY > transform.position.y)
        {
            transform.position = new Vector3(
                transform.position.x,
                targetY,
                transform.position.z
            );
        }
    }
}