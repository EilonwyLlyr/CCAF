using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsideBuildingNavigator : MonoBehaviour
{
    Rigidbody rigidBody;
    public Dropdown dropdownValues;

    public Transform[] secondFloor;
    public Transform[] Door1;
    public Transform[] Door2;

    public Transform startingLocation;
    public Transform endingLocation;

    bool secondFunction = false;

    public float speed;
    private int current;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        onSelect();
    }

    public void onSelect()
    {

        if (dropdownValues.value == 1)
        {
            //skips straight to setdoor2
            //either make setD2 a subfunction
            //or bolean state to false
            secondFloorPath();
            Invoke("Teleport", 1f);

        }
        if (dropdownValues.value == 2)
        {
            secondFloorPath();
            setDoor2();
        }
       
    }

    private void secondFloorPath()
    {
        if (transform.position != secondFloor[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, secondFloor[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % secondFloor.Length;
        }
    }

    private void setDoor2()
    {
        if (transform.position != Door2[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, Door2[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % Door2.Length;
        }
    }

    private void setDoor1()
    {
        if (transform.position != Door1[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, Door1[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % Door1.Length;
        }
    }
    private void mayTeleport()
    {
        if (rigidBody.position == startingLocation.position)
        {
            Teleport();
        }
    }

    void Teleport()
    {
        rigidBody.transform.position = endingLocation.transform.position;

    }

}
