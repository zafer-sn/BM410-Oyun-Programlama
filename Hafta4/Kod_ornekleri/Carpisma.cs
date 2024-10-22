using UnityEngine;

public class Carpisma : MonoBehaviour
{
    // rb2D adýnda Rigidbody2D classýný referans eden referans tipli bir deðiþken tanýmlama
    // public Rigidbody2D rb2D;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Çarpan nesnenin rengini deðiþtirme
        // collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f, 1f);

        // Çarpan nesnenin adý "BeyazKare (1)" ise çalýþacak kod, tag te kullanýlabbilir
        /* if(collision.gameObject.name == "BeyazKare (1)")
        {
            collision.gameObject.SetActive(false);
        } */
        
        // Çarpan nesnelerin Rigidbody2D componentine eriþmek ve ilgili referansa aktarmak
        // rb2D = collision.gameObject.GetComponent<Rigidbody2D>();
        print("Çarptý");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        print("Þu an çarpýþma halinde");

        // Çarpýþma halindeyken Space tuþuna basýldýðýnda yapýlacaklar
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
