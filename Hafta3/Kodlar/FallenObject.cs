using UnityEngine;

public class FallenObject : MonoBehaviour
{
    public GameObject fallenObject;
    public float spawnTime;
    public float tempSpawnTime;

    private void Start()
    {
        tempSpawnTime = spawnTime;
    }


    private void Update()
    {
        spawnTime -= Time.deltaTime;
        // Instantiate metodu ile nesneler oluþturulabilir.
        if (spawnTime <= 0)
        {
            Instantiate
                (fallenObject,
                new Vector3
                (
                    Random.Range(-2f, 2f),
                    fallenObject.transform.position.y,
                    fallenObject.transform.position.z                    
                ),
                Quaternion.identity
                ).GetComponent<SpriteRenderer>().color = new Color
                (
                    Random.Range(0f, 1f),
                    Random.Range(0f, 1f),
                    Random.Range(0f, 1f)
                );
            // Time.deltaTime ekrana getirilen 2 frame arasýndaki süreyi saniye cinsinden verir.
            spawnTime = tempSpawnTime;
        }        
    }
}
