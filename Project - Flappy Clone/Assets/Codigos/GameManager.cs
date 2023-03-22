using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public Text scoreText; 
   public int score; 
   public GameObject GameOverObj;
   public GameObject StartObj;

    void Start()
    {
        Time.timeScale = 0;
        StartObj.SetActive(true);
    }

    public void StartButton()
    {
        Time.timeScale = 1;
        GameOverObj.SetActive(false);
        StartObj.SetActive(false);
    }


    void Update()
    {
                
    }


    public void GameOver()
    {
        
        GameOverObj.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void RestartButton()
    {
        
        SceneManager.LoadScene(0);
    }

    public void Scoring()
    {
        score++;
        scoreText.text = score.ToString();  
    }
}
