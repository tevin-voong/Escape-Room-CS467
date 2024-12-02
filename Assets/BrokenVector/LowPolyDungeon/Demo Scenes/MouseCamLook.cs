using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    void Start()
    {
        // Cursor.lockState = CursorLockMode.Locked;

        // if (PauseMenu.GameIsPaused)
        // {
        //     Cursor.lockState = CursorLockMode.None;
        // }
            
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);

        // if (!PauseMenu.GameIsPaused) 
        // {
        //         Cursor.lockState = CursorLockMode.None;
        // }
        // else 
        // {
        //         Cursor.lockState = CursorLockMode.Locked;
        // }
        
        // if (Input.GetKeyDown(KeyCode.Escape)) 
        // {
        //         if (PauseMenu.GameIsPaused) {
        //             Cursor.lockState = CursorLockMode.Locked;
        //         }
        //         else 
        //         {
        //                 Cursor.lockState = CursorLockMode.None;
        //         }
        // }
    }
}