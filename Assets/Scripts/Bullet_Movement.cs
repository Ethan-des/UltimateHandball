using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Movement : MonoBehaviour
{
    public float boundY = 3.2f;//Determines where the end of the screen is
    public float moveSpeed = 20.0f;//Determines the speed of the bullet

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        do
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        } while (pos.y < boundY);
    }
}
