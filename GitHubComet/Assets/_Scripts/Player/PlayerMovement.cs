using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    protected Rigidbody2D rigidbody2d;

    [field: SerializeField]
    public MovementDataSO MovementData { get; set; }

    [SerializeField]
    protected float currentVelocity = 3;
    protected Vector2 movementDirection;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void MovePlayer(Vector2 movementInput)
    {
        if (movementInput.magnitude > 0)
        {
            movementDirection = movementInput.normalized;
        }
        currentVelocity = CalculateSpeed(movementInput);

    }

    private float CalculateSpeed(Vector2 movementInput)
    {
        if(movementInput.magnitude > 0)
        {
            currentVelocity += MovementData.acceleration * Time.deltaTime;
        }
        else
        {
            currentVelocity -= MovementData.deacceleration * Time.deltaTime;
        }
        return Mathf.Clamp(currentVelocity, 0, MovementData.maxSpeed);
    }

    private void FixedUpdate()
    {
        rigidbody2d.velocity = currentVelocity*movementDirection.normalized;
    }
}
