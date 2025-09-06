using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareDrawer : MonoBehaviour
{  
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Square origin point on the mouse position
        Vector2 squareOriginPoint = Input.mousePosition;

        //Defining the corners of the square and where they are
        Vector2 point1 = Camera.main.ScreenToWorldPoint(squareOriginPoint);
        Vector2 point2 = point1 + new Vector2(3f, 0);
        Vector2 point3 = point1 + new Vector2(3f, 3f);
        Vector2 point4 = point1 + new Vector2(0, 3f);

        //Creates the square upon a left click
        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawLine(point1, point2, Color.green, 5f);
            Debug.DrawLine(point2, point3, Color.green, 5f);
            Debug.DrawLine(point3, point4, Color.green, 5f);
            Debug.DrawLine(point4, point1, Color.green, 5f);
        }
        else if ((Input.mousePosition.x >= -2000) && (Input.mousePosition.x <= 2000)) //Makes a green square follow the mouse
        {
            Debug.DrawLine(point1, point2, Color.green, 0f);
            Debug.DrawLine(point2, point3, Color.green, 0f);
            Debug.DrawLine(point3, point4, Color.green, 0f);
            Debug.DrawLine(point4, point1, Color.green, 0f);
        }
        
    }
}
