using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpingbus : MonoBehaviour
{
    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            ourRigidBody.AddForce(10 * Vector3.up);
        }
    }
}
