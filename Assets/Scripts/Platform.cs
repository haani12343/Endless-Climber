using UnityEngine;
public class Platform : MonoBehaviour
{
    void update()
    {
        Camera cam = Camera.main;
        if (cam == null) return;
        if (transform.position.y < cam.transform.position.y - 20f)
        {
            Destroy(gameObject);
        }
    }
}