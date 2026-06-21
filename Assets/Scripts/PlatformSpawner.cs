using UnityEngine;
public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform player;
    public float verticalGap = 5f;
    public float minX = -3f;
    public float maxX = 3f;
    private float highestPlatformY;
    void Start()
    {
        highestPlatformY = 0f;
        for (int i = 0; i < 20; i++)
        {
            SpawnPlatform();
        }
    }
    void Update()
    {
     if (player.position.y + 30f > highestPlatformY)
        {
            SpawnPlatform();
        }
    }
    void SpawnPlatform()
    {
        float randomX = Random.Range(minX, maxX);
        Instantiate(
            platformPrefab,
            new Vector3(randomX, highestPlatformY, 0),
            Quaternion.identity
        );
        highestPlatformY += verticalGap;
    }
}