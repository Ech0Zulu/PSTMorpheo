using System.IO.Ports;
using UnityEngine;

public class ButtonSys : MonoBehaviour
{
    [SerializeField]
    private GameObject button; // Bouton physique
    private LightSys lightSystem; // R�f�rence au syst�me de lumi�re
    private ArduinoSys arduinoSystem; // R�f�rence au syst�me Arduino

    public float activationThreshold = 1.07f; // Seuil de position pour d�tecter l'appui

    private bool isPressed = false; // �tat actuel du bouton

    private bool toggle = false; // �tat de la lampe

    private void Start()
    {
        lightSystem = GetComponent<LightSys>();
        arduinoSystem = GetComponent<ArduinoSys>();
    }
    private void Update()
    {
        float y = button.transform.position.y;

        // V�rifie si le bouton vient juste d'�tre press�
        if (y <= activationThreshold && !isPressed)
        {
            isPressed = true; // Verrouille l'�tat en tant que "press�"
            toggle = !toggle; // Bascule l'�tat de la lampe
            lightSystem.SetLightState(toggle);
            arduinoSystem.SendToArduino(toggle);
        }
        // V�rifie si le bouton revient � sa position d'origine
        else if (y > activationThreshold && isPressed)
        {
            isPressed = false; // R�initialise l'�tat pour permettre un nouveau basculement
        }
    }
}
