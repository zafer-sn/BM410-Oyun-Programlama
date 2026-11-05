using System;
using TMPro;
using UnityEngine;

public class PlayerScoreControl : MonoBehaviour
{
    int actualScore;
    public TMP_Text scoreText;
    public float time;
    public TMP_Text timeText;
    public GameObject panel;
    
    private void Start()
    {
        panel.SetActive(false);
        actualScore = PlayerPrefs.GetInt("skor");
        scoreText.text = $"Skor: {actualScore}";
    }
    private void Update()
    {
        time -= Time.deltaTime;
        timeText.text = $"Zaman: {Convert.ToInt32(time)}";
        if(time <= 0)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Circle"))
        {
            actualScore += CircleScoreControl.circleScoreValue;
            PlayerPrefs.SetInt("skor", actualScore);
            scoreText.text = $"Skor: {actualScore}";
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Square"))
        {
            actualScore += SquareScoreControl.squareScoreValue;
            PlayerPrefs.SetInt("skor", actualScore);
            scoreText.text = $"Skor: {actualScore}";
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("Triangle"))
        {
            actualScore += TriangleScoreControl.trianglecoreValue;
            PlayerPrefs.SetInt("skor", actualScore);
            scoreText.text = $"Skor: {actualScore}";
            Destroy(collision.gameObject);

        }
    }
}
