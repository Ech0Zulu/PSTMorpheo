using System.IO.Ports;
using UnityEngine;

public class ArduinoSys : MonoBehaviour
{
    public string portName = "COM3"; // Nom du port s�rie
    public int baudRate = 9600; // Vitesse de communication s�rie

    private SerialPort arduinoPort;

    private void Start()
    {
        // Initialiser le port s�rie
        try
        {
            arduinoPort = new SerialPort(portName, baudRate);
            arduinoPort.Open();
            Debug.Log("Port s�rie ouvert : " + portName);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Impossible d'ouvrir le port s�rie : " + e.Message);
        }
    }

    public void SendToArduino(bool isOn)
    {
        if (arduinoPort != null && arduinoPort.IsOpen)
        {
            string message = isOn ? "1" : "0";
            arduinoPort.Write(message);
            Debug.Log("Message envoy� � l'Arduino : " + message);
        }
    }

    private void OnApplicationQuit()
    {
        // Fermer le port s�rie � la fin de l'application
        if (arduinoPort != null && arduinoPort.IsOpen)
        {
            arduinoPort.Close();
        }
    }
}