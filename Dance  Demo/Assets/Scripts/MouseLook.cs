using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform player;
    private float xRotate;
    private float mouseSens;
    

    // Start is called before the first frame update
    void Start()
    {
        xRotate = 0;
        mouseSens = 500f;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);

       
    }
}
