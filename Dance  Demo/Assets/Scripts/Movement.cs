using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public Transform player;
    private Vector3 jump;
    private float jumpForce;
    private bool isGrounded;
    private float moveSpeed;
    private float sens;
    private float xRotate;
    private float yRotate;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sens = 10f;
        moveSpeed = 500f;
        xRotate = 0;
        yRotate = 0;
        jumpForce = 3f;
        jump = new Vector3(0.0f, 1f, 0f);
        isGrounded = true;
}

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime);
        Vector3 newPos = rb.position + rb.transform.TransformDirection(movement);
        rb.MovePosition(newPos);

        float mouseX = Input.GetAxis("Mouse X") * sens;
        float mouseY = Input.GetAxis("Mouse Y") * sens;

        xRotate -= mouseY;
        yRotate += mouseX;
        xRotate = Mathf.Clamp(xRotate, -90, 90);
        transform.rotation = Quaternion.Euler(xRotate, yRotate, 00f);
        player.Rotate(Vector3.up * mouseX);
        player.Rotate(Vector3.left * mouseY);

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(jump * jumpForce, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.AddForce(-(jump * jumpForce), ForceMode.VelocityChange);
        }
    }
  
}
