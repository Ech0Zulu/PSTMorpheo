using UnityEngine;
using System.Collections.Generic;

public class examplee : MonoBehaviour
{
    public ManagerCube managerCube;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            List<int> numberList = new List<int> { 0, 1, 2, 3 };
            List<bool> boolList = new List<bool> { true, false };

            // �����_����1�I��
            int randomNumber = numberList[Random.Range(0, numberList.Count)];
            bool randomBool = boolList[Random.Range(0, boolList.Count)];

            // �o��
            Debug.Log("Number: " + randomNumber + "boolean: " + randomBool);
            managerCube.recieve(randomNumber, randomBool);
        }
    }
}