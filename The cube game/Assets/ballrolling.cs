using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballrolling : MonoBehaviour
{
    private float rotateSpeed = 360;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.rotation *= Quaternion.AngleAxis(rotateSpeed * Time.deltaTime, transform.right);
 
        
    }
}
