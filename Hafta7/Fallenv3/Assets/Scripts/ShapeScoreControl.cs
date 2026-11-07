using UnityEngine;
public enum ShapeType { Circle=1, Square = 2, Triangle=3}
public class ShapeScoreControl : MonoBehaviour
{
    public ShapeType shapeType;
    public int scoreValue;
    private void Start()
    {
        Color color = gameObject.GetComponent<SpriteRenderer>().color;
        scoreValue = (int)shapeType * GetScoreFromColor(color);
    }
    private int GetScoreFromColor(Color color)
    {
        if (color == Color.red) return -1;
        if (color == Color.green) return 2;
        if (color == Color.blue) return 1;
        return 0;
    }
}
