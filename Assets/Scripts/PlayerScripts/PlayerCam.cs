using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    //Provided by this tutorial https://www.youtube.com/watch?v=f473C43s8nE
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    

    void Start()
    {
        //Puts the cursor at the center of the screen and lock it there.
        Cursor.lockState = CursorLockMode.locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //Mouse Input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Rotation and Orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
