using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float runSpeed;
    [SerializeField] private float jumpForce;
    private SpriteRenderer sprite;

    private float xMovement = 0f;

    public Animator animator;

    private enum MovementState{idle, running, jumping, falling}
    // private MovementState state = MovementState.idle;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xMovement * runSpeed, rb.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        UpdateAnimationState();
        
    }

    private void UpdateAnimationState()
    {
        MovementState state;
        if(xMovement > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if(xMovement < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if(rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if(rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        animator.SetInteger("state", (int)state);
    }
}
