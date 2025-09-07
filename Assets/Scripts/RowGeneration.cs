using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RowGeneration : MonoBehaviour
{
    [SerializeField] private int numberOfSquares = 5;
    [SerializeField] private float squareSize = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DrawSquares(numberOfSquares, squareSize);
    }

    public void DrawSquares(int count, float size)
    {
        Vector2 squareOriginPoint = Vector2.zero;

        for (int i = 0; i  < count; i++)
        {
            Vector2 offset = new Vector2(i * size, 0);

            Vector2 point1 = Camera.main.ScreenToWorldPoint(squareOriginPoint + offset);
            Vector2 point2 = point1 + new Vector2(3f, 0);
            Vector2 point3 = point1 + new Vector2(3f, 3f);
            Vector2 point4 = point1 + new Vector2(0, 3f);

            Debug.DrawLine(point1, point2, Color.green, 5f);
            Debug.DrawLine(point2, point3, Color.green, 5f);
            Debug.DrawLine(point3, point4, Color.green, 5f);
            Debug.DrawLine(point4, point1, Color.green, 5f);
        }
    }
}
