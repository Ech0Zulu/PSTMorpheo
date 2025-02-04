using UnityEngine;

public class LightSys : MonoBehaviour
{
    [SerializeField]
    private GameObject lampLight; // Lumière dans Unity

    public void SetLightState(bool isOn)
    {
        lampLight.SetActive(isOn); // Active ou désactive la lumière
        Debug.Log("Lumière " + (isOn ? "allumée" : "éteinte"));
    }
}