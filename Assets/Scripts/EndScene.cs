using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{

    public void Win()
    {

        print("ISCOLLDING");
        if (!Inventory.main.hasShoe) return;
        {

            print(Inventory.main.hasShoe);
            SceneManager.LoadScene("EndScene");
        }

    }
}
