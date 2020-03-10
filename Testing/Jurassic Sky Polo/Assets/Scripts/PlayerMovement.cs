using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerController controls;
    public Rigidbody2D rb;
    public float movespeed = 5f;
    public float jumpForce = 7f;

    Vector2 moveDir;

    private void Awake()
    {
        controls = new PlayerController();

        controls.Birb.Movement.performed += ctx => moveDir = ctx.ReadValue<Vector2>();
        controls.Birb.Movement.canceled += ctx => moveDir = Vector2.zero;

        controls.Birb.WingFlap.performed += ctx => Jump();
    }

    void FixedUpdate()
    {
        Vector2 m = new Vector2(moveDir.x, moveDir.y) * Time.deltaTime * movespeed;

        transform.Translate(m, Space.World);
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
    }

    private void OnEnable()
    {
        controls.Birb.Enable();
    }

    private void OnDisable()
    {
        controls.Birb.Disable();
    }
}
