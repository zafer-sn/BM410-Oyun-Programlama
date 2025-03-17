using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerControl : MonoBehaviour
{
    public Animator animator;
    public int nextLevel;
    public void Fade(int sceneIndex)
    {
        nextLevel = sceneIndex;
        animator.SetTrigger("FadeOut");
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
