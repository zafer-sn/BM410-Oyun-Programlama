using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int health;
    public bool isDead;

    public Transform bullet;
    public Transform barrel;

    public float bulletSpeed;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            ShootBullet();
        }
    }

    public void GetDamage(int damage)
    {
        if((health-damage) >= 0)
        {
            health -= damage;
        } else
        {
            health = 0;
        }      
        AmIDead();
    }

    public void AmIDead()
    {
        if(health <= 0)
        {
            isDead = true;
        }
    }

    public void ShootBullet()
    {
        Transform tempBullet;
        tempBullet = Instantiate(bullet, barrel.position, Quaternion.identity);
        tempBullet.GetComponent<Rigidbody2D>().AddForce(barrel.forward * bulletSpeed);
    }


}
