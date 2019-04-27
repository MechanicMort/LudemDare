using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public Panel menu;
    public Panel control;

    public void startGame()//load the main game
    {
        SceneManager.LoadScene(1);
    }

    public void quit() // allow the user to quit the game
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void controls() // open the controls
    {
        menu.SetActive = false;
        control.SetActive = true;
    }

    public void returnMenu()// open the menu
    {
        menu.SetActive = true;
        control.SetActive = false;
    }

}
