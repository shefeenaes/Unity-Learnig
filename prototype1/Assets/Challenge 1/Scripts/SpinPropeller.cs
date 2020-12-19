﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float propSpeed = 1000;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate the Propeller of the plane
        
        transform.Rotate(Vector3.forward * propSpeed * Time.deltaTime);

    }
}
