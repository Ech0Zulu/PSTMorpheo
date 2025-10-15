using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : MonoBehaviour
{
    public Camera MainCamera;
    public float distanceFromCamera = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = distanceFromCamera;  // カメラからの距離を指定

        // カーソル位置に手オブジェクトを移動
        Vector3 worldPos = MainCamera.ScreenToWorldPoint(mousePos);
        transform.position = worldPos;

    }
}
