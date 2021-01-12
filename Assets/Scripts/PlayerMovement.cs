using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Vector2 borderTop;
    public Vector2 borderBottom;

    private Vector2 movement;
    private Vector2 newPos;
    
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
    }

    private void FixedUpdate()
    {
        newPos = rb.position + movement * (moveSpeed * Time.fixedDeltaTime);

        if (newPos.x > borderTop.x || newPos.y > borderTop.y) return; //TODO: tilføj bund kant
            
        rb.MovePosition(newPos);
    }
}
