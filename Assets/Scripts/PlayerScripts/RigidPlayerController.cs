using UnityEngine;

public class RigidPlayerController : MonoBehaviour
{
    [Header("Movement Attributes")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float sprintSpeed;
 
    [Header("References")]
    [SerializeField] private Camera playerCam;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private PlayerInputHandler pInputHandler;


    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }




}
