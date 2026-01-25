using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if(ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;

            //Negative normal because we need to have the force
            //in the opposite direction in order for it
            // to properly increase speed
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
}
