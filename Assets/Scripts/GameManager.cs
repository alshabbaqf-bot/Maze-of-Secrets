using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int totalCoins = 5;
    public float timeLeft = 60f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public GameObject resultPanel;
    public TextMeshProUGUI resultTitleText;
    public TextMeshProUGUI resultInfoText;

    public bool gameEnded = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (resultPanel != null)
            resultPanel.SetActive(false);

        UpdateScoreUI();
        UpdateTimerUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded) return;

        timeLeft -= Time.deltaTime;
        UpdateTimerUI();

        if (timeLeft <= 0)
        {
            timeLeft = 0;
            LoseGame();
        }
    }

    public void AddScore()
    {
        if (gameEnded) return;

        score++;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Coins: " + score + " / " + totalCoins;
    }

    void UpdateTimerUI()
    {
        timerText.text = "Time: " + Mathf.Ceil(timeLeft) + "s";
    }

    public bool HasAllCoins()
    {
        return score >= totalCoins;
    }

    public void WinGame()
    {
        if (gameEnded) return;

        gameEnded = true;

        if (resultPanel != null)
            resultPanel.SetActive(true);

        if (resultTitleText != null)
            resultTitleText.text = "Game Won!";

        if (resultInfoText != null)
            resultInfoText.text = "Coins: " + score + "/" + totalCoins + "\nTime Left: " + Mathf.Ceil(timeLeft);

    }

    public void LoseGame()
    {
        if (gameEnded) return;

        gameEnded = true;

        if (resultPanel != null)
            resultPanel.SetActive(true);

        if (resultTitleText != null)
            resultTitleText.text = "Time's Up!";

        if (resultInfoText != null)
            resultInfoText.text = "Coins: " + score + "/" + totalCoins;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
