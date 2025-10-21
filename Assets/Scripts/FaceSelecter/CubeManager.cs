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
        StartCoroutine(Animations(faceTag));
        //Debug.Log("CubeManager:" + faceTag);
        GameManager.StartGame(faceTag);
    }

     IEnumerator Animations(string faceTag)
    {
        Transform cube = this.transform;
        Transform cam = MainCamera.transform;

        Vector3 startPos = cube.position;
        Quaternion Rot =cube.rotation;

        Vector3 faceDirect = GetFaceNormal(faceTag);
        Quaternion targetRot = Quaternion.FromToRotation(faceDirect, Vector3.up) * cube.rotation;
        Vector3 targetPos = cam.position + cam.forward * 1.0f + Vector3.down * 0.6f; // ÉJÉÅÉâëO

        float duration = 1.0f;
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime / duration; //calculation
            float smooth = Mathf.SmoothStep(0, 1, t); //smooth
            cube.position = Vector3.Lerp(startPos, targetPos, smooth); //position
            cube.rotation = Quaternion.Slerp(Rot, targetRot, smooth); // rotation
            yield return null;
        }
    }

    Vector3 GetFaceNormal(string faceTag)
        {
            switch (faceTag)
            {
                case "up": return transform.up;
                case "down": return -transform.up;
                case "forward": return transform.forward;
                case "back": return -transform.forward;
                case "left": return -transform.right;
                case "right": return transform.right;
                default: return transform.forward;
            }
        }
}
