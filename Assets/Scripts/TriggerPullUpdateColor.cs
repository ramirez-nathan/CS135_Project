using UnityEngine;
using UnityEngine.InputSystem;

public class TriggerPullUpdateColor : MonoBehaviour
{
    public InputActionReference triggerPullReference;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = triggerPullReference.action.ReadValue<float>();
        UpdateColor(triggerValue);
    }

    private void UpdateColor(float value) {
        meshRenderer.material.color = new Color(value, value, value);
    }
}
