using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Transform borderTop;
    public Transform borderBottom;

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

        if (newPos.x < borderTop.position.x || newPos.x > borderBottom.position.x) newPos.x = rb.position.x;
        if (newPos.y > borderTop.position.y || newPos.y < borderBottom.position.y) newPos.y = rb.position.y;
            
        rb.MovePosition(newPos);
    }
}
