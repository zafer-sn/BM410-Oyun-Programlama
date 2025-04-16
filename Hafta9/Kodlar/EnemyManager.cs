using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public int health;
    public int damage;

    public Slider slider;

    private void Start()
    {
        slider.maxValue = health;
        slider.value = health;        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerManager>().GetDamage(damage);
        }

        if(collision.gameObject.CompareTag("Bullet"))
        {
            GetDamage(collision.gameObject.GetComponent<BulletManager>().damage);
            Destroy(collision.gameObject);
        }
    }

    public void GetDamage(int damage)
    {
        if ((health - damage) >= 0)
        {
            health -= damage;
            slider.value -= damage;
        }
        else
        {
            health = 0;
        }
        AmIDead();        
    }

    public void AmIDead()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
