using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseAndResume : MonoBehaviour
{
    [SerializeField] GameObject resumeGame;

    public void Pause()
    {
        resumeGame.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        resumeGame.SetActive(false);
        Time.timeScale = 1f;
    }
}
