using System;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnPrefab;
    public float sure = 2f;
    public float xDegeri;
    public float yDegeri;

    private void Update()
    {
        if (sure <= 0)
        {
            xDegeri = UnityEngine.Random.Range(-2.5f, 2.5f);
            yDegeri = UnityEngine.Random.Range(5.25f, 8.25f);
            Instantiate(spawnPrefab, new Vector3(xDegeri, yDegeri, 0f), Quaternion.identity);
            sure = 2f;
        }
        else
        {

        }
        sure -= Time.deltaTime;

    }



}
