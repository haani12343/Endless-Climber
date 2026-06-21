using UnityEngine;
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource audioSource;
    public AudioClip jumpSound;
    public AudioClip gameOverSound;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayJump()
    {
        if (jumpSound != null)
        {
            audioSource.PlayOneShot(jumpSound);
        }
    }
    public void PlayGameOver()
    {
        if (gameOverSound != null)
        {
            audioSource.PlayOneShot(gameOverSound);
        }
    }
}