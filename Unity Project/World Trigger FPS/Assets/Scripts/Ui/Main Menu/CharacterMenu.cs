using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMenu : MonoBehaviour
{
    // Parameters

    // Objects
    [SerializeField]
    private MainMenu MainMenuManager;

    // Variables

    // Functions
    public void OpenCharacterMenu()
    {

    }

    public void OpenMainMenu()
    {
        MainMenuManager.OpenMainMenuPage();
    }
}
