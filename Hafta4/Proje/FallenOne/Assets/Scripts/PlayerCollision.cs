using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Player nesnesine �arpan objelerin tagi "BeyazKare" ise skor textine de�eri yazd�rma

    public int skor=0;
    public TMP_Text skorText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BeyazKare")
        {
            Destroy(collision.gameObject);
            skor++;
            skorText.text = "Puan:" + skor.ToString();
        }
    }
}