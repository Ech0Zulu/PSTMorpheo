using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePicker : MonoBehaviour
{
    public Camera MainCamera;
    public GameManager GameManager;
    public CubeManager CubeManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hands"))
        {
            string faceTag = gameObject.tag;
            CubeManager.onClicked(faceTag);
        }
    }

    //void OnMouseDown()
    //{
    //    // �}�E�X�ʒu���烌�C���΂� 
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Ray raycast = MainCamera.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;

    //        // ���C���Ԃ�������
    //        if (Physics.Raycast(raycast, out hit))
    //        {
    //            Debug.Log("hello");
    //            string faceTag = hit.collider.gameObject.tag;
    //            //Debug.Log(faceTag + " �F�ʑ������m");
    //            CubeManager.onClicked(faceTag);
    //        }
    //    }
    //}

}
