using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Rigidbody teleportObject;
    public Transform startingLocation;
    public Transform endingLocation;

    void Start()
    {
        teleportObject = GetComponent<Rigidbody>();

    }

    public void Update()
    {
        mayTeleport();
    }

    private void mayTeleport()
    {
        if (teleportObject.position == startingLocation.position)
        {
            Teleport();
        }
    }

    void Teleport()
    {
        teleportObject.transform.position = endingLocation.transform.position;

    }
}
