using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BadSurgeon : MonoBehaviour
{
    public int goal = -1;
    public int touched = -1;
    public int score = 0;

    public float onGoalTime = 2f;
    public float timer = 0f;
    [SerializeField]
    private ArduinoCom p_arduinoCom;
    [SerializeField]
    private ToolsScript[] c_tools;

    private void Start()
    {
        p_arduinoCom = GetComponent<ArduinoCom>();        
    }

    void Update()
    {
        if (goal < 0)
        {
            p_arduinoCom.SendSig(0);
            goal = Random.Range(6, 13);
            p_arduinoCom.SendSig(goal);
        }

        if (touched == goal)
        {
            timer += Time.deltaTime;
            if (timer >= onGoalTime)
            {
                goal = -1;
                timer = 0f;
                score++;
                int pointer = Mathf.Clamp(score - 1, 0, 15);
                if (c_tools[pointer] != null) c_tools[pointer].SetOn();

            }
        }
        else timer = 0f;
    }

    public void IsTouched(int num)
    {
        touched = num;
    }
}
