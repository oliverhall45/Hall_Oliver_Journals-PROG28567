using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipeline : MonoBehaviour
{
    private Vector2 storedMousePosition;
    private Vector3 previousPosition;
    private bool isMouseHeld = false;
    private Coroutine drawCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            isMouseHeld = true;
            drawCoroutine = StartCoroutine(DrawLines()); //starts drawing
        }

        if (Input.GetMouseButtonUp(0))
        {
            isMouseHeld = false;
            if (drawCoroutine != null)
            {
                StopCoroutine(drawCoroutine); //stops drawing
            }
        }
        if (Input.GetMouseButton(0))
        {
            storedMousePosition = Input.mousePosition; //checks for the mouse position
            Debug.Log("mouse position" + storedMousePosition);
        }
    }

    IEnumerator DrawLines()
    {
        yield return new WaitForSeconds(0.1f);

        while (isMouseHeld)
        {
            Debug.DrawLine(previousPosition, storedMousePosition, Color.red, 1.0f); //draws a line for 1 second
            previousPosition = storedMousePosition;

            yield return new WaitForSeconds(0.1f); //waits 0.1 seconds before ending a part of the line and starting a new one
        }
    }
}

