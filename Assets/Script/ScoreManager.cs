using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public TMP_Text scoreText;
    public string sceneName;
    public TMP_Text winText;
    public GameObject winPanel;
    public GameObject creditPanel;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        winPanel.SetActive(false);
        creditPanel.SetActive(false);
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();

        if (score == 3)
        {
            ShowWinScreen();
        }
    }

    void ShowWinScreen()
    {
        winText.text = "You Win!!";
        winPanel.SetActive(true);
        creditPanel.SetActive(true);
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Snowman : {score}/3";
        }
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
