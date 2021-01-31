using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonControl : MonoBehaviour
{
    [SerializeField] GameObject inventoryObj;
    [SerializeField] GameObject pauseObj;
    public void Unpause()
    {
        pauseObj.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PlayerMovements.gameScreen = 0;
    }
    public void UnInv()
    {
        inventoryObj.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PlayerMovements.gameScreen = 0;
    }

    public void Play()
    {
        SceneManager.LoadScene("GameJam");

    }

    public void Quit()
    {
        Application.Quit();

    }
}
