using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 spawnPoint;

    

    
    private void Start()
    {
        spawnPoint = transform.position;
    }

    private void Update()
    {
        Vector3 input = new Vector3();
        input.x = Input.GetAxisRaw("Horizontal");
        input.z = Input.GetAxisRaw("Vertical");
        transform.position += input * speed * Time.deltaTime;

        if(input!=Vector3.zero)
        {
            transform.forward = input;
        }
           

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(0,0,0);
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Enemy")
        {
            //transform.position = spawnPoint;
            var currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);
            print(currentScene);
        }
    }
}
