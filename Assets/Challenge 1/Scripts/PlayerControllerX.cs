using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField]
    GameObject propeller;

    Transform propellerTransform;

    float speed = 20f;
    float rotationSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        propellerTransform = propeller.GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlaneController();
        PropellerRotation();
    }

    void PlaneController()
    {
        // get the user's vertical input
        float verticalInput = Input.GetAxis("Vertical1");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }

    void PropellerRotation()
    {
        propellerTransform.Rotate(Vector3.forward * rotationSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
