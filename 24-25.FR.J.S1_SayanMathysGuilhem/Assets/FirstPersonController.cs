using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class FirstPersonController : MonoBehaviour
{
    [Header("Movements Speeds")] [SerializeField]
    private float walkSpeed = 0.3f;
    [SerializeField] private float spritMultiplayer = 2.0f;

    [Header("Jump Parameters")] 
    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] private float gravity = 9.81f;
    
    [Header("Inputs Sensitivity")]
    [SerializeField] private float mouseSensitivity = 2.0f;
    [SerializeField] private float upDownRange = 80.0f;

    [Header("Inputs Customisation")]
    [SerializeField] private string horizontalMoveInput = "Horizontal";
    [SerializeField] private string verticalMoveInput = "Vertical";
    [SerializeField] private string MouseXInput = "Mouse X";
    [SerializeField] private string MouseYInput = "Mouse Y";
    [SerializeField] private KeyCode sprintKey = KeyCode.LeftShift;
    [SerializeField] private KeyCode jumpKey = KeyCode.Space;

    private Camera mainCamera; 
    private float verticalRotation;
    private Vector3 currentMovement = Vector3.zero;
    private CharacterController characterController;
    

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        mainCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        HandleMovement();
        HandleRotation();
    }

    void HandleMovement()
    {
        float speedMultiplayer = Input.GetKey(sprintKey) ? spritMultiplayer : 1f;
        float verticalSpeed = Input.GetAxis("Vertical") * walkSpeed * speedMultiplayer * Time.deltaTime;
        float horizontalSpeed = Input.GetAxis(horizontalMoveInput) * walkSpeed * speedMultiplayer * Time.deltaTime;

        Vector3  horizontalMovement =  new Vector3(horizontalSpeed, 0, verticalSpeed);
        horizontalMovement = transform.rotation * horizontalMovement;
        
        HandleGravityAndJumping();

        currentMovement.x = horizontalMovement.x;
        currentMovement.z = horizontalMovement.z;

        characterController.Move(currentMovement * Time.deltaTime);
        
          
    }

    void HandleGravityAndJumping()
    {
        if (characterController.isGrounded)
        {
           // currentMovement.y = -0f;

            if (Input.GetKeyDown(jumpKey))
            {
                currentMovement.y = jumpForce;
            }
        }
        else
        {
            currentMovement.y -= gravity * Time.deltaTime;
        }
    }

    void HandleRotation()
    {
        float mouseXRotation = Input.GetAxis(MouseXInput) * mouseSensitivity * Time.deltaTime;
        float mouseYRotation = Input.GetAxis(MouseYInput) * mouseSensitivity * Time.deltaTime;
        transform.Rotate(0, mouseXRotation,0);

        verticalRotation -= Input.GetAxis(MouseYInput) * mouseSensitivity;
        verticalRotation -= Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        mainCamera.transform.Rotate(-mouseYRotation,0,0);
        mainCamera.transform.Rotate(Vector3.left,mouseXRotation);
    }    
        
 }