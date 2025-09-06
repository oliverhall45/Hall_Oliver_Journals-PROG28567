using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject square;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;

            Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Instantiate(square, spawnPosition, Quaternion.identity);
        }
    }
}
