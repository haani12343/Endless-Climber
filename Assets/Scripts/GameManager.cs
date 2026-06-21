using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public Transform player;
    public GameObject gameOverPanel;
    public TextMeshProUGUI finalScoreText;
    private bool gameOver = false;
    void Update()
    {
        if (!gameOver &&
            player.position.y < Camera.main.transform.position.y - 10f)
        {
            gameOver = true;
            Debug.Log("GAME OVER SOUND");
            AudioManager.Instance.PlayGameOver();
            int score = ScoreManager.Instance.CurrentScore;
            int bestScore = PlayerPrefs.GetInt("BestScore", 0);
            if (score > bestScore)
            {
                bestScore = score;
                PlayerPrefs.SetInt("BestScore", bestScore);
                PlayerPrefs.Save();
            }
            finalScoreText.text =
              "Score: " + score +
              "\nBest: " + bestScore;

            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
}