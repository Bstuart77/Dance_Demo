using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float sens;
    private float moveSpeed;
    private float jumpHeight;
    private float gravity;
    private float groundDistance;
    public CharacterController controller;
    public Transform groundCheck;
    private Vector3 velocity;
    public LayerMask groundMask;

    void Start()
    {
        sens = 10f;
        moveSpeed = 500f;
        gravity = -1000f;
        jumpHeight = 1000;
        groundDistance = 0.4f;
    }

    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * x + transform.forward * z;

        if (Input.GetKey(KeyCode.Space))
        { 
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            velocity.y += gravity * Time.deltaTime;
        }

        controller.Move(velocity * Time.deltaTime);
        controller.Move(movement * moveSpeed * Time.deltaTime);

    }
}
