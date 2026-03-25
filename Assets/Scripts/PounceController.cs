using UnityEngine;

public class PounceController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    [SerializeField] private float ySpeed;
    private float xSpeed;
    [SerializeField] private float xSpeedMult;
    [SerializeField] Trajectory trajectory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateAppliedSpeed();
    }

    void CalculateAppliedSpeed()
    {
        Vector2 mouseLoc = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        xSpeed = (mouseLoc[0] - transform.position.x) * xSpeedMult;
        trajectory.DrawLine(new Vector2(xSpeed, ySpeed));

        if (Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity += new Vector2(xSpeed, ySpeed);
            Debug.Log("Applied speed: " + new Vector2(xSpeed, ySpeed));
        }
    }


}
