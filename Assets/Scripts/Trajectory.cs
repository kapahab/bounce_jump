using UnityEngine;

public class Trajectory : MonoBehaviour
{
    [SerializeField] private int segmentCount;

    [SerializeField] private Vector2[] segmentPositions;
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        segmentPositions = new Vector2[segmentCount];
        lineRenderer.positionCount = segmentCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawLine(Vector2 additionalSpeed)
    {
        Vector2 startPosition = transform.position;
        segmentPositions[0] = startPosition;
        lineRenderer.SetPosition(0, startPosition);

        Vector2 startVelocity = rb.linearVelocity;
        for (int i = 1; i < segmentCount; i++)
        {
            float time = i * Time.fixedDeltaTime;

            Vector2 gravityEffect = 0.5f * Physics2D.gravity * time * time;

            segmentPositions[i] = startPosition + (startVelocity + additionalSpeed) * time + gravityEffect;
            lineRenderer.SetPosition(i, segmentPositions[i]);
        }
    }
}
