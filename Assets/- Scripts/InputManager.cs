using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class InputManager : MonoBehaviour
{
    
    [HideInInspector]public float vertical;
    [HideInInspector]public float horizontal;
    [HideInInspector]public float xValue , yValue;


    private void FixedUpdate()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        xValue = CrossPlatformInputManager.GetAxis("Mouse Y");
        yValue = CrossPlatformInputManager.GetAxis("Mouse X");
    }
}
