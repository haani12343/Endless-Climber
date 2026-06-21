using UnityEngine;
using TMPro;
public class BlinkText : MonoBehaviour
{
    public TextMeshProUGUI textToBlink;
    public float blinkSpeed = 0.5f;
    void Update()
    {
        textToBlink.enabled = 
        Mathf.FloorToInt(Time.unscaledTime / blinkSpeed) % 2 == 0;
    }
}