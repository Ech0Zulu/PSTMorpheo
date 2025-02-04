using System.IO.Ports;
using UnityEngine;

public class ArduinoSys : MonoBehaviour
{
    public string portName = "COM3"; // Nom du port série
    public int baudRate = 9600; // Vitesse de communication série

    private SerialPort arduinoPort;

    private void Start()
    {
        // Initialiser le port série
        try
        {
            arduinoPort = new SerialPort(portName, baudRate);
            arduinoPort.Open();
            Debug.Log("Port série ouvert : " + portName);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Impossible d'ouvrir le port série : " + e.Message);
        }
    }

    public void SendToArduino(bool isOn)
    {
        if (arduinoPort != null && arduinoPort.IsOpen)
        {
            string message = isOn ? "1" : "0";
            arduinoPort.Write(message);
            Debug.Log("Message envoyé à l'Arduino : " + message);
        }
    }

    private void OnApplicationQuit()
    {
        // Fermer le port série à la fin de l'application
        if (arduinoPort != null && arduinoPort.IsOpen)
        {
            arduinoPort.Close();
        }
    }
}