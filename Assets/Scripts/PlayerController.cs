using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 12f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(
            move * moveSpeed,
            rb.linearVelocity.y
        );
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Landed!");
        AudioManager.Instance.PlayJump();
        rb.linearVelocity = new Vector2(
            rb.linearVelocity.x,
            jumpForce
        );
    }
}