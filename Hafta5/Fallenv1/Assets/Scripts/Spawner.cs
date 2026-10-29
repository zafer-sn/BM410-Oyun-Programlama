using UnityEngine;

public class Spawner : MonoBehaviour
{        
    public GameObject[] objects;
    public Color[] colors = {Color.red, Color.green, Color.blue};
    public float time = 3f;    
    private void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            GameObject createdObject = Instantiate(objects[Random.Range(0, 3)],
            new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(5.5f, 7.5f), 0f),
            Quaternion.identity);
            createdObject.GetComponent<SpriteRenderer>().color = colors[Random.Range(0, 3)];
            time = Random.Range(2.5f, 4.5f);
        }        
        // gameObject.GetComponent<SpriteRenderer>().color = Color.
    }
}
