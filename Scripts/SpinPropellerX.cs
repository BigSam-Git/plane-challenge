using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    //Propeller speed variable
    public float turnSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Rotate the propeller
        transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed);
    }
}
