using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class SidePortals : MonoBehaviour
{
    [SerializeField] private Transform destination;
    [SerializeField] private SidePortals otherPortal;
    public List<GameObject> portalObject = new List<GameObject>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (portalObject.Contains(other.gameObject))
            return;

        portalObject.Add(other.gameObject);
        otherPortal.portalObject.Add(other.gameObject);


        Transform otherTransform = other.transform;

        Vector3 newPosition = destination.position;
        newPosition.y = otherTransform.position.y;
        otherTransform.position = newPosition;

    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (portalObject.Contains(other.gameObject))
            portalObject.Remove(other.gameObject);
    }
}
