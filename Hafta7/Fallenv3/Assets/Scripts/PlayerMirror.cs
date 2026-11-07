using UnityEngine;

public class PlayerMirror : MonoBehaviour
{
    public Rigidbody2D rb2D;
    private void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float currentX = rb2D.position.x;
        if(currentX >= 2.81f)
        {
            rb2D.position = new Vector2(-2.81f+0.05f, rb2D.position.y);
        } else if(currentX <= -2.81f)
        {
            rb2D.position = new Vector2(2.81f - 0.05f, rb2D.position.y);
        }
    }
    /*private void Update()
    {
        if(gameObject.transform.position.x >= 2.81f)
        {
            gameObject.transform.position = new Vector3(
                -2.81f,
                gameObject.transform.position.y,
                gameObject.transform.position.z
                );
        }
        else if (gameObject.transform.position.x <= -2.81f)
        {
            gameObject.transform.position = new Vector3(
                2.81f,
                gameObject.transform.position.y,
                gameObject.transform.position.z
                );
        }
    }*/
}
