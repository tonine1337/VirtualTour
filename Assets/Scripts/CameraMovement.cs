using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{
    private bool isDisabled;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
    }


    void Update()
    {
        if (!isDisabled)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            Cursor.lockState = CursorLockMode.Locked; Cursor.visible = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isDisabled = !isDisabled;
        }
    }
}
