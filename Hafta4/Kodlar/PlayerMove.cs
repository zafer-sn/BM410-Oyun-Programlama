using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D playerRB2D;
    Animator playerAnimator;
    public float moveSpeed;
    bool facingRight = true;
    private void Start()
    {
        playerRB2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }
    private void Update()
    {
        HorizontalMove();
        if(playerRB2D.linearVelocity.x > 0 && facingRight == false)
        {
            FlipFace();
        } else if (playerRB2D.linearVelocity.x < 0 && facingRight == true)
        {
            FlipFace();
        }
    }

    void HorizontalMove()
    {
        playerRB2D.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB2D.linearVelocity.y);
        playerAnimator.SetFloat("playerSpeed", Mathf.Abs(playerRB2D.linearVelocity.x));
    }

    void FlipFace()
    {
        // GetComponent<Transform>().localScale
        // transform.localScale
        // gameObject.transform.localScale
        facingRight = !facingRight;
        Vector3 tempTransform = transform.localScale;
        tempTransform.x *= -1;
        transform.localScale = tempTransform;
        // transform.localScale.x *= -1;
    }


}
