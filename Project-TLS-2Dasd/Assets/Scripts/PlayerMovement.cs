using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float vertical;
    float horizontal;
    Vector3 movementVector;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetData();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void GetData()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        movementVector = new Vector2(horizontal, vertical);
    }

    private void Move()
    {
        rb.velocity = movementVector.normalized * Player.Instance.speed.Value;
    }
}
