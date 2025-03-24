using UnityEngine;

public class SquareCollision : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().sleepMode = RigidbodySleepMode2D.NeverSleep;
    }
    // Nesneye temas ettiði anda 1 kez çalýþýr
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("OnCollisionEnter2D çalýþtý");
    }
    // Nesneye temas olduðu sürece çalýþýr
    private void OnCollisionStay2D(Collision2D collision)
    {
        print("OnCollisionStay2D çalýþtý");
    }
    // Nesneyle temas kesildiði anda 1 kez çalýþýr
    private void OnCollisionExit2D(Collision2D collision)
    {
        print("OnCollisionExit2D çalýþtý");
    }
    // Ýlgili alana girildiði anda 1 kez çalýþýr
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("OnTriggerEnter2D çalýþtý");
    }
    // Ýlgili alanda bulunulduðu sürece çalýþýr
    private void OnTriggerStay2D(Collider2D collision)
    {
        print("OnTriggerStay2D çalýþtý");
    }
    // Ýlgili alandan çýkýldýðý anda 1 kez çalýþýr
    private void OnTriggerExit2D(Collider2D collision)
    {
        print("OnTriggerExit2D çalýþtý");
    }
}
