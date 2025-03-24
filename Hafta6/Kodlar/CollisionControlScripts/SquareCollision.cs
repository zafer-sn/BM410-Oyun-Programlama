using UnityEngine;

public class SquareCollision : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().sleepMode = RigidbodySleepMode2D.NeverSleep;
    }
    // Nesneye temas etti�i anda 1 kez �al���r
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("OnCollisionEnter2D �al��t�");
    }
    // Nesneye temas oldu�u s�rece �al���r
    private void OnCollisionStay2D(Collision2D collision)
    {
        print("OnCollisionStay2D �al��t�");
    }
    // Nesneyle temas kesildi�i anda 1 kez �al���r
    private void OnCollisionExit2D(Collision2D collision)
    {
        print("OnCollisionExit2D �al��t�");
    }
    // �lgili alana girildi�i anda 1 kez �al���r
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("OnTriggerEnter2D �al��t�");
    }
    // �lgili alanda bulunuldu�u s�rece �al���r
    private void OnTriggerStay2D(Collider2D collision)
    {
        print("OnTriggerStay2D �al��t�");
    }
    // �lgili alandan ��k�ld��� anda 1 kez �al���r
    private void OnTriggerExit2D(Collider2D collision)
    {
        print("OnTriggerExit2D �al��t�");
    }
}
