using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampaignMenu : MonoBehaviour
{
    // Parameters

    // Objects
    [SerializeField]
    private MainMenu MainMenuManager;

    // Variables

    // Functions
    public void OpenCampainMenu()
    {

    }

    public void OpenMainMenu()
    {
        MainMenuManager.OpenMainMenuPage();
    }
}
