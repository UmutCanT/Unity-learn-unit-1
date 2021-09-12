using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRb;

    [SerializeField]
    Camera[] cameras;

    [SerializeField]
    GameObject centerOfMass;

    [SerializeField]
    string playerID;

    [SerializeField]
    KeyCode camSwitchKey;

    [SerializeField]
    float horsePower = 0f;

    float vehicleSpeed = 20f;
    float turnSpeed = 20f;
   
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        VehicleController();
        CameraController();
    }

    void VehicleController()
    {
        float horizontalInput = Input.GetAxis("Horizontal" + playerID);
        float verticalInput = Input.GetAxis("Vertical" + playerID);

        //transform.Translate(Vector3.forward * verticalInput * vehicleSpeed * Time.deltaTime);
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
    }

    void CameraController()
    {
        if (Input.GetKeyDown(camSwitchKey))
        {
            cameras[0].enabled = !cameras[0].enabled;
            cameras[1].enabled = !cameras[1].enabled;
        }
    }
}
