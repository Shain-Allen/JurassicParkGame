using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        
    }

    public void OnWingFlap()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 100f, ForceMode2D.Force);
    }
}
