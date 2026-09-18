using System;
using UnityEditor.EditorTools;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms;

public class RigidPlayerController : MonoBehaviour
{
    [Header("Movement Attributes")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float sprintSpeed;
    [SerializeField] private float mouseXSens;
    [SerializeField] private float mouseYSens;

    [Tooltip("Up Down Look Range must be a positive int")]
    [SerializeField] private int upDownLookRange;
 
    [Header("References")]
    [SerializeField] private Camera playerCam;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private PlayerInputHandler pInputHandler;


    private float verticalRotation;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleRotation();
    }

    void HandleRotation()
    {
        float mouseXRotation = pInputHandler.RotationInput.x * mouseXSens;
        float mouseYRotation = pInputHandler.RotationInput.y * mouseYSens;
        
        //Vertical camera rotation
        verticalRotation = Mathf.Clamp(verticalRotation - mouseYRotation, -upDownLookRange, upDownLookRange);
        playerCam.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        //Horizontal player rotation
        transform.Rotate(0,mouseXRotation,0);
    }


    void HandleMovement()
    {
        Vector3 movementInput = 
        rb.AddForce(force, ForceMode.Acceleration)
    }




}
