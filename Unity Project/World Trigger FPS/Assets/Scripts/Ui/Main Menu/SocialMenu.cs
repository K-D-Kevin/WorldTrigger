using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialMenu : MonoBehaviour
{
    // Parameters

    // Objects
    [SerializeField]
    private MainMenu MainMenuManager;

    // Variables

    // Functions
    public void OpenSocialMenu()
    {

    }

    public void OpenSocialMenuOnInvite()
    {

    }

    public void OpenMainMenu()
    {
        MainMenuManager.OpenMainMenuPage();
    }
}
