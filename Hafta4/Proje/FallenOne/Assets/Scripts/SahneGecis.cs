using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(1);
        }
    }
}
