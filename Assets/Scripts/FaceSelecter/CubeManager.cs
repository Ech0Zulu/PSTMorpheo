using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class CubeManager : MonoBehaviour
{
    public Camera MainCamera;
    public GameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClicked(string faceTag)
    {
        //Debug.Log("CubeManager‚ªŽó‚¯Žæ‚Á‚½‚æ" + faceTag);
        GameManager.StartGame(faceTag);
    }
}
