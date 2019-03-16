using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour
{

    public static Global global;
    public float scrollSpeed = 2.0f;
    public Text scoreText;
    public GameObject gameOverText;
    public bool gameOver = false;

    private int score = 0;

    // Use this for initialization
    void Awake()
    {
        if (global == null)
        {
            global = this;
            gameOverText.SetActive(false);
            scoreText.text = "score: " + score.ToString();
        }
        else if (this != global)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverText.SetActive(true);
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "score: " + score.ToString();
    }
}
