using UnityEngine;

public class Carpisma : MonoBehaviour
{
    // rb2D ad�nda Rigidbody2D class�n� referans eden referans tipli bir de�i�ken tan�mlama
    // public Rigidbody2D rb2D;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �arpan nesnenin rengini de�i�tirme
        // collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f, 1f);

        // �arpan nesnenin ad� "BeyazKare (1)" ise �al��acak kod, tag te kullan�labbilir
        /* if(collision.gameObject.name == "BeyazKare (1)")
        {
            collision.gameObject.SetActive(false);
        } */
        
        // �arpan nesnelerin Rigidbody2D componentine eri�mek ve ilgili referansa aktarmak
        // rb2D = collision.gameObject.GetComponent<Rigidbody2D>();
        print("�arpt�");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        print("�u an �arp��ma halinde");

        // �arp��ma halindeyken Space tu�una bas�ld���nda yap�lacaklar
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(new Vector2(0f, 500f));
        }*/
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        print("Temas kesildi");
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Tetiklendi");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        print("Tetik halinde");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        print("Tetik kesildi.");
    }
}
