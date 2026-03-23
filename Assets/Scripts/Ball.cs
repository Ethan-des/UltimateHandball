using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 500.0f;

    //public GameOverZone end;

    public bool OutOfBounds = false;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    
    private void Update()
    {
        if(transform.position.x < -10)
        {
            //Destroy(this.gameObject);
            OutOfBounds = true;
        }

        /*
        if(OutOfBounds == true)
        {
            ResetPosition();
            AddStartingForce();
            OutOfBounds = false;
        }
        */
    }
    

    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;

        //AddStartingForce();
    }

    public void AddStartingForce()
    {
        //Greater than half means positive change in x, less than means negative
        float x = -0.5f; //Random.value < 0.5f ? -1.0f : 1.0f;

        //Dicates angles of ball
        float y = 0.5f; //Random.value < 0f ? -0.5f : 0.5f;

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

    //Collision is used when trigger is set to false
    /*
    private void OnCollisionEnter2D(Collider2D Collision2D)
    {
        Debug.Log("Game is now over");
        if (Collision2D.gameObject.CompareTag("Game Over Zone"))
        {
            Destroy(this.gameObject);
            end.GameOver = true;
        }
    }
    */
    
}
