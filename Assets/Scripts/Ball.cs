using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;

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

    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;

        //AddStartingForce();
    }

    public void AddStartingForce()
    {
        //Greater than half means positive change in x, less than means negative
        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        //Dicates angles of ball
        float y = 0.5f; //Random.value < 0f ? -0.5f : 0.5f;

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }
}
