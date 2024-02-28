using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject creditsMenu;
    public GameObject instructions;

    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void quitGame()
    {
        Application.Quit();
    }
    public void loadMainMenu()
    {
        mainMenu.gameObject.SetActive(true);
        creditsMenu.gameObject.SetActive(false);
        instructions.gameObject.SetActive(false);
    }

    public void loadOptions()
    {

        mainMenu.gameObject.SetActive(false);
        creditsMenu.gameObject.SetActive(false);
        instructions.gameObject.SetActive(false);
    }
    public void loadCredits()
    {
        mainMenu.gameObject.SetActive(false);
        creditsMenu.gameObject.SetActive(true);
        instructions.gameObject.SetActive(false);
    }
    public void loadInstructions()
    {
        mainMenu.gameObject.SetActive(false);
        creditsMenu.gameObject.SetActive(false);
        instructions.gameObject.SetActive(true);
    }

}
