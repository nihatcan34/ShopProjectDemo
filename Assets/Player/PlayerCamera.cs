using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public float sensivity = 100f;
    public Transform playerBody;
    float xRotate = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Cursor.lockState == CursorLockMode.Locked)
        {

            float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensivity;
            float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensivity;
            xRotate -= mouseY;
            xRotate = Mathf.Clamp(xRotate, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
    }
}
