using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D playerRB2D;
    Animator playerAnimator;
    public float moveSpeed;
    bool facingRight = true;

    public float jumpSpeed;
    public bool isGround;

    public Transform footTransform;
    public float footRadius;
    public LayerMask footMask;

    public float jumpFreq = 1f, nextJumpTime; 



    private void Start()
    {
        playerRB2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }
    private void Update()
    {
        HorizontalMove();
        OnGroundCheck();
        if(playerRB2D.linearVelocity.x > 0 && facingRight == false)
        {
            FlipFace();
        } else if (playerRB2D.linearVelocity.x < 0 && facingRight == true)
        {
            FlipFace();
        }

        if (Input.GetAxis("Vertical") > 0 && isGround && nextJumpTime < Time.timeSinceLevelLoad)
        {
            nextJumpTime = Time.timeSinceLevelLoad + jumpFreq;
            Jump();
                        
        }

    }
    void Jump()
    {
        playerRB2D.AddForce(new Vector2(0f, jumpSpeed));
    }

    void OnGroundCheck()
    {
        isGround = Physics2D.OverlapCircle(footTransform.position, footRadius, footMask);
        playerAnimator.SetBool("isGround", isGround);

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
