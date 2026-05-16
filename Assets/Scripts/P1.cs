using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour
{
    public float boundY = 3.2f;//Determines where the end of the screen is
    public float moveSpeed = 10.0f;//Determines the speed of the paddle

    protected Rigidbody2D _rigidbody;

    public Ball b;

    //void Awake() => Instance = this;

    void Start()
    {
        b = FindObjectOfType<Ball>(); // <- You can't reference other scripts without this
        Debug.Log(b.OutOfBounds);
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressingUp = Input.GetKey(KeyCode.UpArrow);
        bool isPressingDown = Input.GetKey(KeyCode.DownArrow);

        if (b.OutOfBounds == false)
        {

            if (isPressingUp)
            {
                transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
            }

            if (isPressingDown)
            {
                transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
            }

            //to keep inside the game screen
            var pos = transform.position;
            if (pos.y > boundY)
            {
                pos.y = boundY;
            }
            else if (pos.y < -boundY)
            {
                pos.y = -boundY;
            }
            transform.position = pos;
        }
    }

    public void ResetPosition()
    {
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.linearVelocity = Vector2.zero;
    }
}
