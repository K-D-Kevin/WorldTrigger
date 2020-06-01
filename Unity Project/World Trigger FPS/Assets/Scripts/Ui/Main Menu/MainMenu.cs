using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Objects
    [SerializeField]
    private SmartButtonManager MainMenuButtonManager;
    [SerializeField]
    private GameObject MainMenuOnOff;
    [SerializeField]
    private GameObject CampaignOnOff;
    [SerializeField]
    private GameObject PlayOnOff;
    [SerializeField]
    private GameObject LoadoutsOnOff;
    [SerializeField]
    private GameObject CharacterOnOff;
    [SerializeField]
    private GameObject SocialOnOff;
    [SerializeField]
    private GameObject SettingsOnOff;
    [SerializeField]
    private CampaignMenu CampaignMenuManager;
    [SerializeField]
    private PlayMenu PlayMenuManager;
    [SerializeField]
    private LoadoutsMenu LoadoutsMenuManager;
    [SerializeField]
    private CharacterMenu CharacterMenuManager;
    [SerializeField]
    private SocialMenu SocialMenuManager;
    [SerializeField]
    private SettingsMenu SettingsMenuManager;

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

    public void OpenMainMenuPage()
    {
        MainMenuOnOff.gameObject.SetActive(true);
        ResetMainMenu();
        CampaignOnOff.gameObject.SetActive(false);
        PlayOnOff.gameObject.SetActive(false);
        LoadoutsOnOff.gameObject.SetActive(false);
        CharacterOnOff.gameObject.SetActive(false);
        SocialOnOff.gameObject.SetActive(false);
        SettingsOnOff.gameObject.SetActive(false);
    }

    public void OpenCampaignPage()
    {
        CampaignOnOff.gameObject.SetActive(true);
        MainMenuOnOff.gameObject.SetActive(false);
        PlayOnOff.gameObject.SetActive(false);
        LoadoutsOnOff.gameObject.SetActive(false);
        CharacterOnOff.gameObject.SetActive(false);
        SocialOnOff.gameObject.SetActive(false);
        SettingsOnOff.gameObject.SetActive(false);
    }

    public void OpenPlayPage()
    {
        PlayOnOff.gameObject.SetActive(true);
        PlayMenuManager.OpenPlayMenu();
        MainMenuOnOff.gameObject.SetActive(false);
        CampaignOnOff.gameObject.SetActive(false);
        LoadoutsOnOff.gameObject.SetActive(false);
        CharacterOnOff.gameObject.SetActive(false);
        SocialOnOff.gameObject.SetActive(false);
        SettingsOnOff.gameObject.SetActive(false);
    }

    public void OpenLoadoutsPage()
    {
        LoadoutsOnOff.gameObject.SetActive(true);
        LoadoutsMenuManager.OpenLoadoutsMenu();
        MainMenuOnOff.gameObject.SetActive(false);
        CampaignOnOff.gameObject.SetActive(false);
        PlayOnOff.gameObject.SetActive(false);
        CharacterOnOff.gameObject.SetActive(false);
        SocialOnOff.gameObject.SetActive(false);
        SettingsOnOff.gameObject.SetActive(false);
    }

    public void OpenCharacterPage()
    {
        CharacterOnOff.gameObject.SetActive(true);
        CharacterMenuManager.OpenCharacterMenu();
        MainMenuOnOff.gameObject.SetActive(false);
        CampaignOnOff.gameObject.SetActive(false);
        PlayOnOff.gameObject.SetActive(false);
        LoadoutsOnOff.gameObject.SetActive(false);
        SocialOnOff.gameObject.SetActive(false);
        SettingsOnOff.gameObject.SetActive(false);
    }

    public void OpenSocialPage()
    {
        SocialOnOff.gameObject.SetActive(true);
        SocialMenuManager.OpenSocialMenu();
        MainMenuOnOff.gameObject.SetActive(false);
        CampaignOnOff.gameObject.SetActive(false);
        PlayOnOff.gameObject.SetActive(false);
        LoadoutsOnOff.gameObject.SetActive(false);
        CharacterOnOff.gameObject.SetActive(false);
        SettingsOnOff.gameObject.SetActive(false);
    }

    public void OpenSocialPageOnInvite()
    {
        SocialOnOff.gameObject.SetActive(true);
        SocialMenuManager.OpenSocialMenuOnInvite();
        MainMenuOnOff.gameObject.SetActive(false);
        CampaignOnOff.gameObject.SetActive(false);
        PlayOnOff.gameObject.SetActive(false);
        LoadoutsOnOff.gameObject.SetActive(false);
        CharacterOnOff.gameObject.SetActive(false);
        SettingsOnOff.gameObject.SetActive(false);
    }

    public void OpenSocialPageOnPlayerProfile()
    {
        SocialOnOff.gameObject.SetActive(true);
        SocialMenuManager.OpenSocialMenuOnInvite();
        MainMenuOnOff.gameObject.SetActive(false);
        CampaignOnOff.gameObject.SetActive(false);
        PlayOnOff.gameObject.SetActive(false);
        LoadoutsOnOff.gameObject.SetActive(false);
        CharacterOnOff.gameObject.SetActive(false);
        SettingsOnOff.gameObject.SetActive(false);
    }

    public void OpenSettingsPage()
    {
        SettingsOnOff.gameObject.SetActive(true);
        SettingsMenuManager.OpenSettingsMenu();
        MainMenuOnOff.gameObject.SetActive(false);
        CampaignOnOff.gameObject.SetActive(false);
        PlayOnOff.gameObject.SetActive(false);
        LoadoutsOnOff.gameObject.SetActive(false);
        CharacterOnOff.gameObject.SetActive(false);
        SocialOnOff.gameObject.SetActive(false);
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
