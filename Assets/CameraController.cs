using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Set Speed from Mouse Input
    public float speedX = 1.0f;
    public float speedY = 1.0f;

    private float cam = 0.0f;
    private float pitch = 0.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        RightClickInput();
    }


    private void RightClickInput()
    {
        if (Input.GetMouseButton(0))
        {
            cam += speedX * Input.GetAxis("Mouse X");
            cam -= speedY * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, cam, 0.0f);
        }
    }
}
