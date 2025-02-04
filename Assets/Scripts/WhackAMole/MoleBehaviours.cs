using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public bool hit = false;

    [SerializeField]
    private GameObject m_gameSys;

    void Update()
    {
        if (hit)
        {
            hit = false;
            m_gameSys.GetComponent<GameSys>().MoleHit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        hit = true;
        
    }

}
