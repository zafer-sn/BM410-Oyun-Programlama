using UnityEngine;

public class FloorCollision : MonoBehaviour
{
    public PlayerMove pm;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("collisionCircle"))
        {
            pm.score -= 1;
            Destroy(collision.gameObject);
        }
    }
}
