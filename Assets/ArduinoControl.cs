using System.IO.Ports;
using UnityEngine;

public class ArduinoControl : MonoBehaviour
{
    SerialPort arduino = new SerialPort("COM4", 9600); // Replace "COM3" with your Arduino's port

    void Start()
    {
        if (!arduino.IsOpen)
        {
            arduino.Open();
            arduino.DtrEnable = true; // Reset Arduino on connect
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Replace with your Unity button logic
        {
            arduino.Write("A"); // Send signal to Arduino
        }
    }

    private void OnApplicationQuit()
    {
        if (arduino.IsOpen)
        {
            arduino.Close();
        }
    }
}
