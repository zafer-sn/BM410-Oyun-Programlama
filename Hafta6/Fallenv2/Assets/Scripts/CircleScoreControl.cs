using UnityEngine;

public class CircleScoreControl : MonoBehaviour
{
    public static int circleScoreValue;
    private void Start()
    {
        Color color = gameObject.GetComponent<SpriteRenderer>().color;
        if (color == Color.red) circleScoreValue = -1;
        else if (color == Color.green) circleScoreValue = 2;
        else if (color == Color.blue) circleScoreValue = 1;
    }
}
