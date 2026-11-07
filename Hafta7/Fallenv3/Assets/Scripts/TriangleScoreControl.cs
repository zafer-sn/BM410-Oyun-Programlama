using UnityEngine;

public class TriangleScoreControl : MonoBehaviour
{
    public static int trianglecoreValue;
    private void Start()
    {
        Color color = gameObject.GetComponent<SpriteRenderer>().color;
        if (color == Color.red) trianglecoreValue = -2;
        else if (color == Color.green) trianglecoreValue = 4;
        else if (color == Color.blue) trianglecoreValue = 2;
    }
}
