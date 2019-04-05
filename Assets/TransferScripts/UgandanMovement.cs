using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UgandanMovement : MonoBehaviour {
    public float xAngle, yAngle, zAngle;
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
        RespondToForward();
        RespondToRotate();
    }


void RespondToForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.AddRelativeForce(Vector3.forward * initialThrust);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidBody.AddRelativeForce(-Vector3.forward * initialThrust);
        }
    }

    void RespondToRotate()
    {
        // rigidBody.freezeRotation = true;
        // float rotationSpeed = rcsThrust * Time.deltaTime;
       // transform.position = new Vector3(0.75f, 0f, 0f);
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddRelativeForce(Vector3.left * rcsThrust);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddRelativeForce(Vector3.right * rcsThrust);
        }
       // if (Input.GetKey(KeyCode.LeftArrow))
        //{
          //  transform.Rotate(xAngle, yAngle,zAngle);
        //}
      //  rigidBody.freezeRotation = false;

    }
   //void OnCollisionEnter(Collision collision)
    //{
      //  switch (collision.gameObject.tag)
        //{
          //  case "Friendly":
          
        //        break;
       //     case "Bio Building":
       //         LoadNextLevel();
       //         break;
       //     case "Finish2":
       //         break;
       //     default:
       //         break;
       // }
    //}

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}

