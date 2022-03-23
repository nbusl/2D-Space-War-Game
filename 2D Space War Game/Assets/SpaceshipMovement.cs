using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float rotateSpeed = 60;
    public float moveSpeed = 8;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.angularVelocity = Input.GetAxis("Vertical") * rotateSpeed;
        rb.velocity = transform.up * Input.GetAxis("Horizontal") * moveSpeed;
    }

}
