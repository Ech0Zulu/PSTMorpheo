using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToolsScript : MonoBehaviour
{

    [SerializeField]
    private Material m_hiddenMat;
    [SerializeField]
    private Material m_visibleMat;

    [SerializeField]
    private GameObject c_light;
    [SerializeField]
    private Renderer[] c_renderers;

    //public bool state;

    void Start()
    {
        c_renderers = GetComponentsInChildren<Renderer>();
    }

    /*private void Update()
    {
        if (state) SetOn();
        else if (!state) SetOff();
    }*/

    public void SetOn()
    {
        if(c_light!=null) c_light.SetActive(true);
        foreach (Renderer renderer in c_renderers)
        {
            if (renderer != null)
            {
                renderer.material = m_visibleMat;
            }
        }
    }
    public void SetOff()
    {
        if (c_light != null) c_light.SetActive(false);  
        foreach (Renderer renderer in c_renderers)
        {
            if (renderer != null)
            {
                renderer.material = m_hiddenMat;
            }
        }
    }
}
