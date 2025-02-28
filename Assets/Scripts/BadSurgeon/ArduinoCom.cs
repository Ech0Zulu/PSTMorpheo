using System.Drawing;
using System.IO.Ports;
using UnityEngine;

public class ArduinoCom : MonoBehaviour
{
    public string portName = "COM12"; // Nom du port série
    public int baudRate = 9600; // Vitesse de communication série
    private SerialPort arduinoPort;

    //Debug
    
    public bool SIGNONE = false;
    public bool SIGALL = false;
    public bool SIG6 = false;
    public bool SIG7 = false;
    public bool SIG8 = false;
    public bool SIG9 = false;
    public bool SIG10 = false;
    public bool SIG11 = false;
    public bool SIG12 = false;
    public bool SIG13 = false;


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
    //DEBUG
    
    private void Update()
    {
        if (arduinoPort != null && arduinoPort.IsOpen)
        {
            if (SIGNONE)
            {
                arduinoPort.Write("0");
                Debug.Log("SIGNONE Turned On");
                SIGNONE = false;
            }
            if (SIGALL)
            {
                arduinoPort.Write("1");
                Debug.Log("SIGALL Turned On");
                SIGALL = false;
            }
            if (SIG6)
            {
                arduinoPort.Write("6");
                Debug.Log("SIG6 Turned On");
                SIG6 = false;
            }
            if (SIG7)
            {
                arduinoPort.Write("7");
                Debug.Log("SIG7 Turned On");
                SIG7 = false;
            }
            if (SIG8)
            {
                arduinoPort.Write("8");
                Debug.Log("SIG8 Turned On");
                SIG8 = false;
            }
            if (SIG9)
            {
                arduinoPort.Write("9");
                Debug.Log("SIG9 Turned On");
                SIG9 = false;
            }
            if (SIG10)
            {
                arduinoPort.Write("10");
                Debug.Log("SIG10 Turned On");
                SIG10 = false;
            }
            if (SIG11)
            {
                arduinoPort.Write("11");
                Debug.Log("SIG11 Turned On");
                SIG11 = false;
            }
            if (SIG12)
            {
                arduinoPort.Write("12");
                Debug.Log("SIG12 Turned On");
                SIG12 = false;
            }
            if (SIG13)
            {
                arduinoPort.Write("13");
                Debug.Log("SIG13 Turned On");
                SIG13 = false;
            }
        }
    }

    public void SendSig (int SIG)
    {
        //Debug.Log("[TRY to SEND] : " + SIG + " to the Arduino");
        if ((SIG >= 6 && SIG <= 13) || SIG == 1 || SIG == 0)
        {
            arduinoPort.Write(SIG.ToString());
            Debug.Log("[SENT] : " + SIG);
        }
    }

    private void OnApplicationQuit()
    {
        arduinoPort.Write("0");
        // Fermer le port série à la fin de l'application
        if (arduinoPort != null && arduinoPort.IsOpen)
        {
            arduinoPort.Close();
        }
    }
}