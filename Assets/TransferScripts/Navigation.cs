using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navigation : MonoBehaviour
{
    Rigidbody rigidBody;
    public Dropdown dropdownValues;

    public Transform[] BioPath;
    public Transform[] JFK;
    public Transform[] KHPath;
    public Transform[] SalazarPath;


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
            setBioBuildingPath();
        }
        if (dropdownValues.value == 2)
        {
            setJFKPath();
        }
        if (dropdownValues.value == 3)
        {
            setKingHallPath();
        }
        if (dropdownValues.value == 4)
        {
            setSalazarPath();
        }
    }

    private void setSalazarPath()
    {
        if (transform.position != SalazarPath[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, SalazarPath[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % SalazarPath.Length;
        }
    }

    private void setKingHallPath()
    {
        if (transform.position != KHPath[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, KHPath[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % KHPath.Length;
        }
    }

    public void setBioBuildingPath()
    {
        if (transform.position != BioPath[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, BioPath[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % BioPath.Length;
    }
    public void setJFKPath()
    {
        if (transform.position != JFK[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, JFK[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);

        }
        else
        {
            current = (current + 1) % JFK.Length;
        }
    }
}
