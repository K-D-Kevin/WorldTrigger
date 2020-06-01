using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampaignMenu : MonoBehaviour
{
    // Parameters

    // Objects
    [SerializeField]
    private MainMenu MainMenuManager;
    [SerializeField]
    private SmartButtonManager HasSaveButtonManager;
    [SerializeField]
    private SmartButtonManager HasNoSaveButtonManager;
    [SerializeField]
    private GameObject HasSaveObject;
    [SerializeField]
    private GameObject HasNoSaveObject;

    // Variables

    // Functions
    public void OpenCampainMenu()
    {
        if (GetSave())
        {
            HasSaveObject.gameObject.SetActive(true);
            HasNoSaveButtonManager.gameObject.SetActive(false);
            HasSaveButtonManager.ReturnToDefault();
        }
        else
        {
            HasNoSaveButtonManager.gameObject.SetActive(true);
            HasSaveObject.gameObject.SetActive(false);
            HasNoSaveButtonManager.ReturnToDefault();
        }
    }

    public void OpenMainMenu()
    {
        MainMenuManager.OpenMainMenuPage();
    }

    public void LoadContinue()
    {

    }

    public void LoadAutosave()
    {

    }

    public void LoadNewGame()
    {

    }

    public bool GetSave()
    {
        return false;
    }
}
