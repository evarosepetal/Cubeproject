using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingkart : MonoBehaviour
{
    ballrolling[] allWheels;
    private float carTurningSpeed = 180f;

    // Start is called before the first frame update
    void Start()
    {
        allWheels = FindObjectsOfType<ballrolling>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime;
            updateWheelPositions();
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, carTurningSpeed * Time.deltaTime);
            updateWheelPositions();
        }

       

        
    }

    private void updateWheelPositions()
    {
        allWheels[0].transform.position = transform.position + 0.6f * transform.right - 0.5f * transform.up + 0.5f * transform.forward;
        allWheels[0].transform.rotation = transform.rotation;
        allWheels[1].transform.position = transform.position - 0.6f * transform.right - 0.5f * transform.up + 0.5f * transform.forward;
        allWheels[1].transform.rotation = transform.rotation;
        allWheels[2].transform.position = transform.position + 0.6f * transform.right - 0.5f * transform.up- 0.5f * transform.forward;
        allWheels[2].transform.rotation = transform.rotation;
        allWheels[3].transform.position = transform.position- 0.6f * transform.right - 0.5f * transform.up - 0.5f * transform.forward;
        allWheels[3].transform.rotation = transform.rotation;
    }
}
