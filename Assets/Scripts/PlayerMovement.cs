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

        if (newPos.x < borderTop.x || newPos.x > borderBottom.x) newPos.x = rb.position.x; //TODO: tilføj bund kant
        if (newPos.y > borderTop.y || newPos.y < borderBottom.y) newPos.y = rb.position.y;
            
        rb.MovePosition(newPos);
    }
}
