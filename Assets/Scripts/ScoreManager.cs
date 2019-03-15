using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    static public int speed = 2;
    static public int score = 0;
    private int highScore;
    public Text scoreText;
    public Text highestScoreText;


    void Awake()
    {
        // if (PlayerPrefs.HasKey("HighestScore"))
        // {
        //     highestScore = PlayerPrefs.GetInt("HighestScore");
        // }
        // PlayerPrefs.SetInt("HighestScore", score);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HighestScore"))
        {
        highestScoreText.text = "Highest Score: " + PlayerPrefs.GetInt("HighestScore").ToString();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void BalloonScored()
    {
        score++;
        speed += 1;
        scoreText.text = "Score: " + score.ToString();
        if(score > highScore){
            highScore = score;
            PlayerPrefs.SetInt("HighestScore", highScore);
        }
        
        
    }

     void OnTriggerEnter2D (Collider2D other)
  {
          BalloonScored();
  }
}
