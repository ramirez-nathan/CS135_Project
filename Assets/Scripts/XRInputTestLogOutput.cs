using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class XRInputTestLogOutput : MonoBehaviour
{
    public InputActionReference buttonPressA;
    public InputActionReference buttonPressB;
    public InputActionReference buttonPressX;
    public InputActionReference buttonPressY;
    public InputActionReference triggerPressRight;
    public InputActionReference gripPressRight;
    public InputActionReference triggerPressLeft;
    public InputActionReference gripPressLeft;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        if (buttonPressA != null && buttonPressA.action != null) {
            buttonPressA.action.performed += OnButtonPressA;
        }
        if (buttonPressB != null && buttonPressB.action != null) {
            buttonPressB.action.performed += OnButtonPressB;
        }
        if (buttonPressX != null && buttonPressX.action != null) {
            buttonPressX.action.performed += OnButtonPressX;
        }
        if (buttonPressY != null && buttonPressY.action != null) {
            buttonPressY.action.performed += OnButtonPressY;
        }
        if (triggerPressRight != null && triggerPressRight.action != null) {
            triggerPressRight.action.performed += OnTriggerPressRight;
        }
        if (gripPressRight != null && gripPressRight.action != null) {
            gripPressRight.action.performed += OnGripPressRight;
        }
        if (triggerPressLeft != null && triggerPressLeft.action != null) {
            triggerPressLeft.action.performed += OnTriggerPressLeft;
        }
        if (gripPressLeft != null && gripPressLeft.action != null) {
            gripPressLeft.action.performed += OnGripPressLeft;
        }
    }

    private void OnDisable()
    {
        if (buttonPressA != null && buttonPressA.action != null) {
            buttonPressA.action.performed -= OnButtonPressA;
        }
        if (buttonPressB != null && buttonPressB.action != null) {
            buttonPressB.action.performed -= OnButtonPressB;
        }
        if (buttonPressX != null && buttonPressX.action != null) {
            buttonPressX.action.performed -= OnButtonPressX;
        }
        if (buttonPressY != null && buttonPressY.action != null) {
            buttonPressY.action.performed -= OnButtonPressY;
        }
        if (triggerPressRight != null && triggerPressRight.action != null) {
            triggerPressRight.action.performed -= OnTriggerPressRight;
        }
        if (gripPressRight != null && gripPressRight.action != null) {
            gripPressRight.action.performed -= OnGripPressRight;
        }
        if (triggerPressLeft != null && triggerPressLeft.action != null) {
            triggerPressLeft.action.performed -= OnTriggerPressLeft;
        }
        if (gripPressLeft != null && gripPressLeft.action != null) {
            gripPressLeft.action.performed -= OnGripPressLeft;
        }
    }

    private void OnButtonPressA(InputAction.CallbackContext context) 
    {
        Debug.Log("[CS 135] The A button on the right controller was pressed.");
    }
    private void OnButtonPressB(InputAction.CallbackContext context) 
    {
        Debug.Log("[CS 135] The B button on the right controller was pressed.");
    }
    private void OnButtonPressX(InputAction.CallbackContext context) 
    {
        Debug.Log("[CS 135] The X button on the right controller was pressed.");
    }
    private void OnButtonPressY(InputAction.CallbackContext context) 
    {
        Debug.Log("[CS 135] The Y button on the right controller was pressed.");
    }
    private void OnTriggerPressRight(InputAction.CallbackContext callback) 
    {
        float triggerValue = callback.ReadValue<float>();
        Debug.Log("[CS 135] Right trigger button: " + triggerValue);
    }
    private void OnGripPressRight(InputAction.CallbackContext callback) 
    {
        float triggerValue = callback.ReadValue<float>();
        Debug.Log("[CS 135] Right grip button: " + triggerValue);
    }
    private void OnTriggerPressLeft(InputAction.CallbackContext callback) 
    {
        float triggerValue = callback.ReadValue<float>();
        Debug.Log("[CS 135] Left trigger button: " + triggerValue);
    }
    private void OnGripPressLeft(InputAction.CallbackContext callback) 
    {
        float triggerValue = callback.ReadValue<float>();
        Debug.Log("[CS 135] Left grip button: " + triggerValue);
    }
}
