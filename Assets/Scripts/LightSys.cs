using UnityEngine;

public class LightSys : MonoBehaviour
{
    [SerializeField]
    private GameObject lampLight; // Lumi�re dans Unity

    public void SetLightState(bool isOn)
    {
        lampLight.SetActive(isOn); // Active ou d�sactive la lumi�re
        Debug.Log("Lumi�re " + (isOn ? "allum�e" : "�teinte"));
    }
}