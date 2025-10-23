using UnityEngine;

public class Games : MonoBehaviour
{
    public void OnCommandReceived()
    {
        Debug.Log("From face :" + gameObject.name);
    }
}