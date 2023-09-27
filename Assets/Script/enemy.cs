using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Vector3 moveSpeed;
    
    private void Update()
    {

        transform.position += moveSpeed * Time.deltaTime;


    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ground") return;

        moveSpeed = -moveSpeed;
    }
}
