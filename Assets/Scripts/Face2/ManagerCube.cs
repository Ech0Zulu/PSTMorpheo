using UnityEngine;

public class ManagerCube : MonoBehaviour 
{
    public examplee examplee;
    public GameObject[] targetObjects;

    public void recieve(int randomNumber , bool randombool)
    {
        if (randombool == true) 
        {
            Debug.Log("From manager : " + randomNumber);

            // �����_���i���o�[�ɑΉ�����I�u�W�F�N�g��I��

                GameObject target = targetObjects[randomNumber];
                target.SendMessage("OnCommandReceived");

        }

    }

}
