using UnityEngine;
public class FloatingImage : MonoBehaviour
{
    public float floatAmount = 10f;
    public float floatSpeed = 2f;
    private Vector3 startPos;
    void Start()
    {
        startPos = transform.localPosition;
    }
    void Update()
    {
        transform.localPosition = startPos +
        new Vector3(0, Mathf.Sin(Time.time * floatSpeed) * floatAmount, 0);
    }
}