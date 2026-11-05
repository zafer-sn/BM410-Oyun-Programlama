using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveX;
    public float moveSpeed;
    public Rigidbody2D rb2D;
    private void Update()
    { 
        moveX = Input.GetAxisRaw("Horizontal");
        Debug.Log(moveX);
        // A tuşuna tıklandığı sürece çalışır
        /*if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("A tuşuna basıldı(GetKey)");
        }
        // S tuşuna tıklandığı anda 1 kez çalışır

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S tuşuna basıldı(GetKeyDown)");
        }
        // D tuşuna tıklanıp parmak ilgili tuştan çekildiğinde 1 kez çalışır

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("D tuşuna basıldı(GetKeyUp)");
        }
        // Mouse sol tuşuna tıklandığı sürece çalışır

        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse sol tusuna tiklandi");

        }
        // Mouse sağ tuşuna tıklandığında 1 kez çalışır

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse sag tusuna tiklandi");

        }
        // Mouse teker tuşuna tıklanıp parmak ilgili tuştan çekildiğinde 1 kez çalışır

        if (Input.GetMouseButtonUp(2))
        {
            Debug.Log("Mouse teker tusuna tiklandi");

        }*/
    }
    private void FixedUpdate()
    {
        rb2D.linearVelocity = new Vector2(moveX * moveSpeed, rb2D.linearVelocity.y);
    }
}
