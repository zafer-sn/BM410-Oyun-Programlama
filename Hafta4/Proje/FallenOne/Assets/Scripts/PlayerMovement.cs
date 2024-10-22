using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2D;  
    public float hareketHizi = 2f;

    private void Start()
    {
        // gameObject.AddComponent<Rigidbody2D>();   
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float hareket = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(hareket * hareketHizi * Time.deltaTime, 0f);
    }
}
