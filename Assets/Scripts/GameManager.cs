using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int totalCoins = 5;
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Coins: " + score + " / " + totalCoins;
    }
}
