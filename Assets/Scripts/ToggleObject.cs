using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleObject : MonoBehaviour
{
    public InputActionReference buttonPressReference;

    private void Awake()
    {
        if (buttonPressReference != null && buttonPressReference.action != null)
        {
            buttonPressReference.action.performed += Toggle;
        }
    }

    private void Toggle(InputAction.CallbackContext callback)
    {
        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        if (buttonPressReference != null && buttonPressReference.action != null)
        {
            buttonPressReference.action.performed -= Toggle;
        }
    }
}
