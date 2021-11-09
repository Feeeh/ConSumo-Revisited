using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    private float horizontal;
    private float vertical;
    private float speed = 100f;

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed * Time.fixedDeltaTime, vertical * speed * Time.fixedDeltaTime);
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
        vertical = context.ReadValue<Vector2>().y;
    }
}
