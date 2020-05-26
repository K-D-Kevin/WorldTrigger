using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    // Parameters

    // Objects
    [SerializeField]
    private MainMenu MainMenuManager;

    // Variables

    // Functions
    public void OpenSettingsMenu()
    {

    }

    public void OpenMainMenu()
    {
        MainMenuManager.OpenMainMenuPage();
    }
}
