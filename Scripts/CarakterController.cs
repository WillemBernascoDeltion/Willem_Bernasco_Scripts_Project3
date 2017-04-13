using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarakterController : MonoBehaviour
{

    public float speed = 10.0f;
    private float verticalOrientation = 0.0f;
    private float verticalRange = 60.0f;

    void Start()
    {
        //dit zorgt ervoor dat de curser vast staat in het midden van het scherm
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        //dit zorgt ervoor dat de speler kan lopen
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        verticalOrientation -= Input.GetAxis("Mouse Y") * speed;
        verticalOrientation = Mathf.Clamp(verticalOrientation, -verticalRange, verticalRange);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalOrientation, 0, 0);

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

    }
}

