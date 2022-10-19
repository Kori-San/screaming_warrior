using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Player quit the game!");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("PlayScene");
        Debug.Log("Player enter in the game");
    }
}
