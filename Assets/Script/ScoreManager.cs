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
    public GameObject backPanel;
    public GameObject uiPanel;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        winPanel.SetActive(false);
        creditPanel.SetActive(false);
        backPanel.SetActive(false);
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();

        if (score == 3)
        {
            ShowWinScreen();
            Time.timeScale = 0;
        }
    }

    void ShowWinScreen()
    {
        winText.text = "You Win!!";
        winPanel.SetActive(true);
        creditPanel.SetActive(true);
        backPanel.SetActive(true);

        uiPanel.SetActive(false);
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
