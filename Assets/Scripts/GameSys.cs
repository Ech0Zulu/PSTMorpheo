using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

enum State
{
    UP = 0,
    DOWN = 1,
    MIDDLEUP = 2,
    MIDDLEDOWN = 3,
}

public class GameSys : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> m_spawns;
    [SerializeField]
    private GameObject m_mole;
    [SerializeField]
    private Vector2 m_upTime = new Vector2(1, 2);
    [SerializeField]
    private Vector2 m_downTime = new Vector2(1,2);

    private float m_curTimer = 0f;
    private float m_curTime = 0f;
    private State m_state = State.DOWN;
    private float m_moleSizeY = 0f;

    private void Start()
    {
        if (m_spawns == null || m_spawns.Count == 0)
        {
            Debug.LogError("Spawn points not set!");
            return;
        }

        m_moleSizeY = m_mole.GetComponent<Renderer>().bounds.size.y;
        //first timer initialisation
        m_curTimer = UnityEngine.Random.Range(m_downTime.x, m_downTime.y);
    }

    void Update()
    {
        // update the current timer
        m_curTime += Time.deltaTime;

        if (m_state == State.DOWN && m_curTime >= m_curTimer) // if the mole is hidden and has to shown
        {
                m_state = State.MIDDLEUP;
                m_curTime = 0;
        }
        else if (m_state == State.UP) // if the mole is shown
        {
            //check if the player hit the mole
            
            //else check if the mole has to go down
            if (m_curTime >= m_curTimer)
            {
                m_state = State.MIDDLEDOWN;
                m_curTime = 0;
            }
            //else wait
        }
        else // else the mole has to go up or down
        {
            // chose a random new position
            int pos = UnityEngine.Random.Range(0, m_spawns.Count);
            Transform newPos = m_spawns[pos].transform;
            if (m_state == State.MIDDLEUP) // if the mole is going up
            {
                // set the new position and rise it
                m_mole.transform.position = newPos.position + new Vector3(0, m_moleSizeY / 2f, 0);
                m_state = State.UP;
                // set the new random up timer
                m_curTimer = UnityEngine.Random.Range(m_upTime.x, m_upTime.y);
            }
            else // if the mole is going down
            {
                // set the new position and lower it
                m_mole.transform.position = newPos.position - new Vector3(0, m_moleSizeY / 2f, 0);
                m_state = State.DOWN;
                // set the new random down timer
                m_curTimer = UnityEngine.Random.Range(m_downTime.x, m_downTime.y);
            }
        }
    }
}
