using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Components
    private Rigidbody2D rb;

    // Serialized fields
    [SerializeField] private LayerMask groundLayer;

    // private fields
    
    private float xVelocity = 5f;
    private float jumpVelocity = 3f;

    // public fields

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        if(hInput > 0)
        {
            rb.velocity = new Vector2(xVelocity, rb.velocity.y);
        }
        else if(hInput < 0)
        {
            rb.velocity = new Vector2(-xVelocity, rb.velocity.y);
        }

        if(Input.GetButton("Jump"))
        {
            if(rb.IsTouchingLayers(groundLayer))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
            }
        }

    }
}
