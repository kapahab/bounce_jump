using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    [FormerlySerializedAs("ySpeed")] [SerializeField] private float jumpYSpeed;
    private float jumpXSpeed;
    [FormerlySerializedAs("jumpxSpeedMult")] [SerializeField] private float jumpXSpeedMult;
    [SerializeField] Trajectory trajectory;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CalculateAppliedSpeed();
    }


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
}