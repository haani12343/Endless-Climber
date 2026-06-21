using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    void Start()
    {
    int bestScore = PlayerPrefs.GetInt("BestScore", 0);
    bestScoreText.text = "BEST SCORE: " + bestScore;
    }
    public void PlayGame()
    {
    SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
}