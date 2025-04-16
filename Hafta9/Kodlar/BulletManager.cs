using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public float lifeTime;
    public int damage;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
