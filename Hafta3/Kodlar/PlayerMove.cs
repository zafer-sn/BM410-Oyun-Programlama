using TMPro;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public TMP_Text scoreText;
    public int score;
    /*
     int degiskenDegeri -> camelCase
    int DegiskenDegeri -> PascalCase
    int degisken_degeri -> snake_case
     */
    private void Start()
    {
        score = PlayerPrefs.GetInt("score");
        scoreText.text = score.ToString();
    }
    private void Update()
    {
        /*if(Input.GetKey(KeyCode.U))
        {
            print("U ya bas�ld�");
        }*/
        float xMove = Input.GetAxis("Horizontal") * moveSpeed;
        // gameObject scriptin s�r�klenip b�rak�larak at�ld��� nesneyi ifade eder.
        gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(xMove, 0f);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("collisionCircle"))
        {
            score += 2;
            PlayerPrefs.SetInt("score", score);
            scoreText.text = score.ToString();
            Destroy(collision.gameObject);
        }
        /*if (collision.gameObject.tag == "collisionCircle")
        {
            Destroy(collision.gameObject);
        }*/
        // Belirli bir s�re sonra ilgili metodu �al��t�r�r.
        // Invoke("scoreKaydet", 5f);



    }
    /*
    public void scoreKaydet()
    {
        PlayerPrefs.SetInt("score", score);
    }*/
}
