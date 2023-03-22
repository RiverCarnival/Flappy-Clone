using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public Vector3 axis;
   public float gravidade = -9f;
   public float force = 5f; 
   private GameManager gameManager; 


    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        axis.y += gravidade * Time.deltaTime;
        transform.position += axis * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.W) ||  Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            axis = Vector2.up * force;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacles"))
        {
            gameManager.GameOver();
        }
        if(collision.CompareTag("Scoring"))
        {
            gameManager.Scoring();
        }

    }

}
