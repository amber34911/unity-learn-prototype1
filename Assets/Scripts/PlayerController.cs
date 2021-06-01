using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed = 20.0f;
    public int id;
    public GameObject cameraSwitch;
    private float horizontalInput;
    private float forwardInput;
    private bool switchInput;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + id);
        forwardInput = Input.GetAxis("Vertical" + id);

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); // speed m/s

        // Turn the vehicle left or right by input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);


        switchInput = Input.GetButtonDown("SwitchCamera" + id);
        if (switchInput)
        {
            cameraSwitch.GetComponent<CameraSwitch>().Toggle();
        }
    }
}


