using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [Header("References")]
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform orientation;

    [Header("Movement")]
    [SerializeField] private float walkSpeed = 40f;
    [SerializeField] private float sprintSpeed = 65f;

    [Header("Drag")]
    [SerializeField] private float drag = 6f;

    private Vector3 moveDirection;

    private float horizontalInput;
    private float verticalInput;

    [SerializeField] private bool sprint = false;

    private void Start() => rb.freezeRotation = true;

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        moveDirection = (orientation.forward * verticalInput + orientation.right * horizontalInput).normalized;

        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprint = true;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprint = false;
        }
        
        //moveDirection = (orientation.forward * verticalInput + orientation.right * horizontalInput).normalized;


        rb.drag = drag;
    }

    private void FixedUpdate()
    {
        
        if(sprint == true)
        {
            rb.AddForce(moveDirection * sprintSpeed, ForceMode.Acceleration);
        }

        else
        {
            rb.AddForce(moveDirection * walkSpeed, ForceMode.Acceleration);
        }
        
        rb.AddForce(moveDirection * walkSpeed, ForceMode.Acceleration);



    }
}