using System;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    [SerializeField] Rigidbody2D rig;
    [SerializeField] LayerMask playerLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.position.y > transform.position.y)
        {
            other.collider.excludeLayers = playerLayer;
        }
        else
        {
            other.collider.includeLayers = playerLayer;
        }
        
    }
}
