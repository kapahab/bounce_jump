using System;
using UnityEngine;

public class PlatformJump : MonoBehaviour
{
    public float jumpForce = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter2D(Collision2D other)
    //{
    //    if(other.relativeVelocity.y <= 0f)
    //    {
    //        Rigidbody2D rb = other.collider.GetComponent<Rigidbody2D>();
    //        if (rb != null)
    //        {
    //            Vector2 velocity = rb.linearVelocity;
    //            velocity.y = jumpForce;
    //            rb.linearVelocity = velocity;
    //            rb.AddForceAtPosition(other.contacts[0].normalImpulse, other.contacts[0].point);
    //        }
    //    }
        
    //}
}
