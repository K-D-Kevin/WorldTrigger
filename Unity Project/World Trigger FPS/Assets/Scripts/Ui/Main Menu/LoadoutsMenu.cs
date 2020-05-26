using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadoutsMenu : MonoBehaviour
{
    // Parameters

    // Objects
    [SerializeField]
    private MainMenu MainMenuManager;

    // Variables

    // Functions
    public void OpenLoadoutsMenu()
    {

    }

    public void OpenMainMenu()
    {
        MainMenuManager.OpenMainMenuPage();
    }
}
