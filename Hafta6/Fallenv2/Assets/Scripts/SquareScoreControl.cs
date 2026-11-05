using UnityEngine;

public class SquareScoreControl : MonoBehaviour
{
    public static int squareScoreValue;
    private void Start()
    {
        Color color = gameObject.GetComponent<SpriteRenderer>().color;
        if (color == Color.red) squareScoreValue = -3;
        else if (color == Color.green) squareScoreValue = 6;
        else if (color == Color.blue) squareScoreValue = 3;
    }
}
