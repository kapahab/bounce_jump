# bounce_jump
A doodle jump-like game that uses a "pounce" mechanic

Unity's rigid body and physics systems were used to create a simple platformer. The player points the mouse to where they want to pounce, and when the button is clicked the player character gets an impulse and flies off in that direction. Below is the function that calculates this force:


    void CalculateAppliedSpeed()
    {
        Vector3 screenPos = Input.mousePosition;
        screenPos.z = Mathf.Abs(Camera.main.transform.position.z);
        Vector2 mouseLoc = Camera.main.ScreenToWorldPoint(screenPos);

        jumpXSpeed = (mouseLoc.x - transform.position.x) * jumpXSpeedMult;
        trajectory.DrawLine(new Vector2(jumpXSpeed, jumpYSpeed)); 

        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(new Vector2(jumpXSpeed, jumpYSpeed), ForceMode2D.Impulse);
            transform.DOPunchScale(new Vector3(-0.75f,-0.75f, 0), 0.1f);
            Debug.Log("Pounced with Impulse Force: " + new Vector2(jumpXSpeed, jumpYSpeed));
        }
    }

There is also a "portal" mechanic like in doodle jump where if the player tries to move off screen from the sides, they are teleported to the other side. This is done by the simple script below:

```
public class SidePortals : MonoBehaviour
{
    [SerializeField] private Transform destination;
    [SerializeField] private SidePortals otherPortal;
    public List<GameObject> portalObject = new List<GameObject>();
    
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
```

The "portals" are just empty objects with a 2D Edge Collider triggers.
