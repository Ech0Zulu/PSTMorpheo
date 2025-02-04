using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject GameSys;
    
    private void OnTriggerEnter(Collider other)
    {
        GameSys.GetComponent<BadSurgeon>().IsTouched(int.Parse(this.name));
        //Debug.Log(name + " : touched");
    }

}
