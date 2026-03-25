using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform track;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        TrackObject();
    }

    void TrackObject()
    {
        if (track.position.y > transform.position.y)
            transform.position = new Vector3(transform.position.x, track.position.y, transform.position.z);
    }
}
