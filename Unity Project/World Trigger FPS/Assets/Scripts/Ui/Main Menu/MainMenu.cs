using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Objects
    [SerializeField]
    private SmartButtonManager MainMenuButtonManager;

    // Functions
    private void Awake()
    {
        ResetMainMenu();
    }

    //private void Update()
    //{
    //    MainMenuButtonManager.SetToButton(MainMenuButtonManager.CurrentSmartButton);
    //}

    public void ResetMainMenu()
    {
        MainMenuButtonManager.CurrentSmartButton = MainMenuButtonManager.DefaultSmartButton;
        MainMenuButtonManager.ReturnToDefault();
    }

    public void OpenCampaignPage()
    {

    }

    public void OpenPlayPage()
    {

    }

    public void OpenLoadoutsPage()
    {

    }

    public void OpenCharacterPage()
    {

    }

    public void OpenControlsPage()
    {

    }

    public void OpenSettingsPage()
    {

    }

    public void ExitToDesktop()
    {
        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }
}
