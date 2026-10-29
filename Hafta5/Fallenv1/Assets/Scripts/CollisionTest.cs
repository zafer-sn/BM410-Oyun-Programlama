using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D çalıştı");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("OnCollisionStay2D çalıştı");

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit2D çalıştı");

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2D çalıştı");

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("OnTriggerStay2D çalıştı");

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("OnTriggerExit2D çalıştı");

    }

}
