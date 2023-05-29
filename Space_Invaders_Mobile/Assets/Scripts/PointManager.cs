using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int currentScore;
    public TMP_Text scoreText;
    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + currentScore;
    }

    public void UpdateScore(int points)
    {
        currentScore += points;
        scoreText.text = "Score: " + currentScore;
    }

    public void HighScoreUpdate()
    {
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            if (currentScore > PlayerPrefs.GetInt("SavedHighScore"))
            {
                PlayerPrefs.SetInt("SavedHighScore", currentScore);
            }
        }
        else
        {
            PlayerPrefs.SetInt("SavedHighScore", currentScore);
        }

        UpdateFinalScoreText();
        UpdateHighScoreText();
    }

    private void UpdateFinalScoreText()
    {
        finalScoreText.text = currentScore.ToString();
    }

    private void UpdateHighScoreText()
    {
        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
    }
}

   
