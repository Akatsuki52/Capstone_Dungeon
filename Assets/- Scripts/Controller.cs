using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private InputManager inputManager;
    private Rigidbody rigidbody;
    public GameObject cameraObject;
    public float movementSpeed = 1f;

    private void Start()
    {
        inputManager = GetComponent<InputManager>();
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(transform.forward * (inputManager.vertical * movementSpeed));
        rigidbody.AddForce(transform.right * (inputManager.horizontal * movementSpeed));

        transform.localRotation *= Quaternion.Euler(0f,inputManager.yValue, 0f);
        cameraObject.transform.localRotation *= Quaternion.Euler(-inputManager.xValue ,0f ,0f);
    }
}
