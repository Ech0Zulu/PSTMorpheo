using System.IO.Ports;
using UnityEngine;

public class ButtonSys : MonoBehaviour
{
    [SerializeField]
    private GameObject button; // Bouton physique
    private LightSys lightSystem; // Référence au système de lumière
    private ArduinoSys arduinoSystem; // Référence au système Arduino

    public float activationThreshold = 1.07f; // Seuil de position pour détecter l'appui

    private bool isPressed = false; // État actuel du bouton

    private bool toggle = false; // État de la lampe

    private void Start()
    {
        lightSystem = GetComponent<LightSys>();
        arduinoSystem = GetComponent<ArduinoSys>();
    }
    private void Update()
    {
        float y = button.transform.position.y;

        // Vérifie si le bouton vient juste d'être pressé
        if (y <= activationThreshold && !isPressed)
        {
            isPressed = true; // Verrouille l'état en tant que "pressé"
            toggle = !toggle; // Bascule l'état de la lampe
            lightSystem.SetLightState(toggle);
            arduinoSystem.SendToArduino(toggle);
        }
        // Vérifie si le bouton revient à sa position d'origine
        else if (y > activationThreshold && isPressed)
        {
            isPressed = false; // Réinitialise l'état pour permettre un nouveau basculement
        }
    }
}
