using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text targetText;
    public TMP_Text timerText;

    public GameObject resultPanel;
    public TMP_Text resultText;

    public int totalTargets = 7;

    private int collectedTargets = 0;
    private float timeRemaining = 30f;
    private bool gameEnded = false;

    void Start()
    {
        Time.timeScale = 1f;

        resultPanel.SetActive(false);

        UpdateTargetText();
        UpdateTimerText();
    }

    void Update()
    {
        if (gameEnded)
            return;

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                UpdateTimerText();
                LoseGame();
                return;
            }

            UpdateTimerText();
        }
    }

    void UpdateTargetText()
    {
        targetText.text = "TARGETS: " + collectedTargets + " / " + totalTargets;
    }

    void UpdateTimerText()
    {
        timerText.text = "TIME: " + Mathf.CeilToInt(timeRemaining);
    }

    public void TargetCollected()
    {
        if (gameEnded)
            return;

        collectedTargets++;
        UpdateTargetText();

        if (collectedTargets >= totalTargets)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        gameEnded = true;
        resultText.text = "YOU WON!";
        resultPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    void LoseGame()
    {
        gameEnded = true;
        resultText.text = "TIME'S UP!";
        resultPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}