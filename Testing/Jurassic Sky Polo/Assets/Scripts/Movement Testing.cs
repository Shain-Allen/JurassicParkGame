using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementTesting : MonoBehaviour
{
    PlayerController controls;

    Rigidbody2D rb;

    Vector2 moveDir;

    private void Awake()
    {
        controls = new PlayerController();

        controls.Birb.Movement.performed += ctx => Move();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Move()
    {
        rb.MovePosition(transform.position * moveDir);
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
