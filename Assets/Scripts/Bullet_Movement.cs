using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Movement : MonoBehaviour
{
    public float bulletLife = 10000f; //Defines how long bullet is on screen
    public float rotation = 0f; //Bullet rotation
    public float speed = 5f; //Bullet speed

    private Vector2 spawnPoint; // Saves X and Y coordinates of where bullet first spawns
    private float timer = 0f; // Counts up when bullet is spawned

    // Start is called before the first frame update
    void Start()
    {
        //Get where the bullet spawns and save it to the spawnpoint variable
        spawnPoint = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy bullet when timer has exceeded life
        if (timer > bulletLife) Destroy(this.gameObject);

        //How timer counts
        timer += Time.deltaTime;

        //Changing position of bullet
        //Movement is a function within this script
        transform.position = Movement(timer);
    }

    //Movement Function, uses the timer variable
    private Vector2 Movement(float timer)
    {
        // Moves right according to the bullet's rotation

        //Changes X and Y to the next calculated position

        //speed = how fast bullet moves
        //transform.right = how far in X and Y direction we should go

        float x = timer * speed * -transform.right.x;
        float y = timer * speed * transform.right.y;

        //Return a vector 2 that take our calculation and returns it to spawnPoint
        return new Vector2(x + spawnPoint.x, y + spawnPoint.y);
    }
}
