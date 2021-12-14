using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameCore : MonoBehaviour
{
    //variables
    [SerializeField] private GameObject m_gameOver;
    [SerializeField] private GameObject m_MainMenu;
    [SerializeField] private Text m_scoreText;
    private int m_score = 0;
    public bool m_isPause = true;

    void Start()
    {
        m_isPause = true;
        m_gameOver.SetActive(false);
        Time.timeScale = 0f;
    }

    public void AddPoint()
    {
        m_score++;
        m_scoreText.text = m_score.ToString();
    }
    public void GameOver()
    {
        m_gameOver.SetActive(true);
        m_isPause = true;
    }

    public void Reload()
    {
        SceneManager.LoadScene(0);
    }

    public void StartTheGame()
    {
        Time.timeScale = 1f;
        m_MainMenu.SetActive(false);
        m_isPause = false;
    }
}
