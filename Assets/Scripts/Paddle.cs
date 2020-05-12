using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Configuration parameters
    [SerializeField] float screenWidthInUnits = 16;
    [SerializeField] int minX = 2;
    [SerializeField] int maxX = 14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float mouseXPosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mouseXPosInUnits, minX, maxX);
        transform.position = paddlePos;
    }
}
