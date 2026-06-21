using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public Transform player;
    public TextMeshProUGUI scoreText;
    private float highestY;
    public int CurrentScore
    {
        get { return Mathf.FloorToInt(highestY); }
    }
    void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        if (player.position.y > highestY)
        {
            highestY = player.position.y;
        }
        scoreText.text = "Score: " + CurrentScore;
    }
}