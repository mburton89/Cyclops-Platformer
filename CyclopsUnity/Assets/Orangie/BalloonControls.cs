using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonControls : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    [SerializeField] private float speed = 4f;
    [SerializeField] private float jumpPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Flip();
    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(horizontal * speed, vertical * speed);
        Vector2 velocity = new Vector2(horizontal * speed, vertical * speed);
        rb.AddForce(velocity);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
