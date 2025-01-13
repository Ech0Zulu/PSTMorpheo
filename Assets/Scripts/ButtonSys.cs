using System.IO.Ports;
using UnityEngine;

public class ButtonSys : MonoBehaviour
{
    [SerializeField]
    private GameObject button; // Physical Button
    private LightSys lightSystem; // Light System Reference
    private ArduinoSys arduinoSystem; // Arduino System Reference

    public float activationThreshold = 1.07f; // Activation Threshold

    private bool isPressed = false; // Button Actual State

    private bool toggle = false; // Lamp Actual State

    private void Start()
    {
        lightSystem = GetComponent<LightSys>();
        arduinoSystem = GetComponent<ArduinoSys>();
    }
    private void Update()
    {
        float y = button.transform.position.y;

        // Check if the button has been pressed
        if (y <= activationThreshold && !isPressed)
        {
            isPressed = true; // Lock in pressed mode
            toggle = !toggle; // Switch lamp state
            lightSystem.SetLightState(toggle);
            arduinoSystem.SendToArduino(toggle);
        }
        // Check if the button went to it's original position
        else if (y > activationThreshold && isPressed)
        {
            isPressed = false; // Reset state
        }
    }
}
