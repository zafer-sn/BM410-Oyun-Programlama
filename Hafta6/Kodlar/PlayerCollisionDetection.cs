using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionDetection : MonoBehaviour
{
    public Transform startTransform;
    public TMP_Text scoreText;
    public TMP_Text timeText;
    public int score;
    public float time;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Saw"))
        {
            transform.position = startTransform.position;
            // SceneManager.LoadScene(1);
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gold"))
        {
            score++;
            scoreText.text = $"Score: {score}";
            Destroy(collision.gameObject);
        }
    }

    private void Update()
    {
        time += Time.deltaTime;
        // timeText.text = $"Time: {time:F2}";
        timeText.text = $"Time: {Mathf.Round(time)}";
    }
}
