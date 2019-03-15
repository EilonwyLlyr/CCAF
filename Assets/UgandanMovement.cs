using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UgandanMovement : MonoBehaviour {
    Rigidbody rigidBody;
    [SerializeField] float rcsThrust = 100f;
    [SerializeField] float initialThrust = 100f;


    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        movement();
    }


void RespondToForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.AddRelativeForce(Vector3.up * initialThrust);
        }
    }

    void RespondToRotate()
    {
        rigidBody.freezeRotation = true;
        float rotationSpeed = rcsThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationSpeed);
        }
      
        rigidBody.freezeRotation = false;

    }
    void movement()
    {

        if (Input.GetKey(KeyCode.A))
        {
            float move = Input.GetAxis("Horizontal");
            GetComponent<Rigidbody>().velocity = new Vector3(move * rcsThrust, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
 }
    }
}

