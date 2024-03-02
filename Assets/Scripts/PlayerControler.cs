using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{   
    private float forwardSpeed = 5.0f;
    private float turnSpeed=20.0f;
    private float horizontalSpeed;
    private float verticalSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        horizontalSpeed=Input.GetAxis("Horizontal");
        verticalSpeed = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime*forwardSpeed*verticalSpeed);
        transform.Rotate(Vector3.up , Time.deltaTime*turnSpeed*horizontalSpeed);
    }
}
