using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5; 
    public float leftBound = -5; 
    public float rightBound = 5; 

    private bool movingRight = true;

    void Update()
    {
       
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

       
        if (transform.position.x >= rightBound)
        {
            movingRight = false;
        }
        else if (transform.position.x <= leftBound)
        {
            movingRight = true;
        }
    }
}

