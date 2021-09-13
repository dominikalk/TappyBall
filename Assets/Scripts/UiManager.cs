using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{

    public static UiManager instance;
    public Text scoreText;
    public GameObject GameOverPanel;
    public GameObject StartUI;
    public GameObject GameOverText;
    public Text highScoreText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreManager.instance.score.ToString();
    }

    public void GameStart()
    {
        StartUI.SetActive(false);
    }

    public void GameOver()
    {
        GameOverText.SetActive(true);
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt ("HighScore");
        GameOverPanel.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene("level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

}

