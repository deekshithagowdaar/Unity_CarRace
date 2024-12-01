using System;
using System.Collections;
using UnityEngine;



public class carcontrol : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnspeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
   
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0,0,1);
        // transform.Translate(Vector3.forward*Time.deltaTime*20);
    horizontalInput = Input.GetAxis("Horizontal");
    forwardInput = Input.GetAxis("Vertical");
    transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
    transform.Rotate(Vector3.up , turnspeed*horizontalInput*Time.deltaTime);
    }

    
}
