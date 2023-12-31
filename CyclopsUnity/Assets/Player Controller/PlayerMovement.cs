using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    [SerializeField] private float speed = 8f;
    [SerializeField] private float jumpPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Start()
    {
        
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if ((Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            SoundManager.Instance.PlaySound(SoundManager.SoundEffect.Jump);
        }

        if ((Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();

        if (IsGrounded())
        {
            if (rb.velocity.x > 0.1f || rb.velocity.x < -0.1f)
            {
                CharacterAnimationManager.Instance.ShowWalk();
            }
            else
            {
                CharacterAnimationManager.Instance.ShowIdle();
            }
        }
        else
        {
            if (rb.velocity.y > 0)
            {
                CharacterAnimationManager.Instance.ShowJump();
            }
            else
            {
                CharacterAnimationManager.Instance.ShowFall();
            }
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
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
