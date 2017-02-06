﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class NonUFPSPlayerController : MonoBehaviour
{
    [SerializeField] float cameraSensitivityX = 5, cameraSensitivityY = 3, movementSpeed = 5;
    
    Rigidbody rb;

    const float minimumLookAngle = -45, maximumLookAngle = 45;
    float rotationX, rotationY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        LookHorizontal();
        LookVertical();
    }

    void FixedUpdate()
    {
        Move();
    }



    void LookHorizontal()
    {
        rotationX = Input.GetAxis("Mouse X") * cameraSensitivityX;
        transform.Rotate(0, rotationX, 0);
    }

    void LookVertical()
    {
        rotationY -= Input.GetAxis("Mouse Y") * cameraSensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumLookAngle, maximumLookAngle);
        Camera.main.transform.localEulerAngles = new Vector3(rotationY, 0, 0);
    }

    void Move()
    {
        Vector3 movementDirection = new Vector3
            (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * movementSpeed;
        
        movementDirection = transform.TransformDirection
            (Vector3.ClampMagnitude(movementDirection, movementSpeed) * Time.deltaTime);
        
        rb.MovePosition(transform.position + movementDirection);
    }
}