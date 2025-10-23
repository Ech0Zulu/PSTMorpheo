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

            // ランダムナンバーに対応するオブジェクトを選択

                GameObject target = targetObjects[randomNumber];
                target.SendMessage("OnCommandReceived");

        }

    }

}
