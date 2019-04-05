using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    //Set Speed from Mouse Input
    public float speedX = 1.0f;
    public float speedY = 1.0f;
    //Detects double click
    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;
    //Camera movement
    private float cam = 0.0f;
    private float pitch = 0.0f;
    private float width;
    private float height;

    public bool camMovement = false;

    private float selectTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
        SelectingLong();
    }

    private void TouchMoveCamera()
    {
        if (Input.touchCount > 0)
        {
            camMovement = true;
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                pos.y = (pos.y - height) / height;
                transform.eulerAngles = new Vector3(pitch, cam, 0.0f);

            }

        }
        else camMovement = false;
    }

    private void MoveCamera()
    {
        //RightClickInput();
        // TouchMoveCamera();
    }


    private void RightClickInput()
    {

        if (Input.GetMouseButton(0))
        {
            camMovement = true;
            cam += speedX * Input.GetAxis("Mouse X");
            cam -= speedY * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, cam, 0.0f);
        }
    }
    private void SelectingLong()
    {
        if (DoubleClick() == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    switch (hit.transform.gameObject.tag)
                    {
                        case "Bio Building":
                            LoadNextLevel();
                            break;
                        default:
                            break;
                    }
                }
            }

        }
    }
    private void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
   
    bool DoubleClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clicked++;
            if (clicked == 1) clicktime = Time.time;
        }
        if (clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            return true;
        }
        else if (clicked > 2 || Time.time - clicktime > 1) clicked = 0;
        return false;
    }
}
