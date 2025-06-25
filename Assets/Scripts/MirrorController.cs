
using UnityEngine;

public class MirrorController : MonoBehaviour
{
    public Transform playerA;
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Ground Check
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // Mirrored Movement (Horizontal)
        float playerAMoveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(-playerAMoveInput * moveSpeed, rb.velocity.y);

        // Mirrored Jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}

