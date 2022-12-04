using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    private float x;
    private float z;
    float mouseSensitivity = 200;
    float xRotation;
    public Transform player;
    RaycastHit hit;
    public float interactionRange = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        transform.forward = Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        z = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;
        xRotation -= z;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * x);

        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, interactionRange))
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    if (Physics.Raycast(transform.position, transform.forward, out hit, interactionRange))
                    {
                        Debug.Log(hit.collider.name);
                    }
                }
            }
        }
    }
}
