using UnityEngine;
public class BackgroundFollow : MonoBehaviour
{
    void LateUpdate()
    {
        if (Camera.main == null) return;
        Vector3 pos = transform.position;
        pos.y = Camera.main.transform.position.y;
        transform.position = pos;
    }
}