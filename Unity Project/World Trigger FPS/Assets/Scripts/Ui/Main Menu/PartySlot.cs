using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartySlot : MonoBehaviour
{
    // Parameters
    [SerializeField]
    private bool IsDirectPlayer = false;

    // Objects
    [SerializeField]
    private Image IconImage;
    [SerializeField]
    private MainMenu MainMenuManager;

    // Variables
    public Image Icon { get { return IconImage; } }
    private Sprite SpriteImage;
    public Sprite IconSprite { get { return SpriteImage; } set { SpriteImage = value; Icon.sprite = SpriteImage; } }
    public string DisplayName = "";
    public string PlayersName { get { return DisplayName; } set { DisplayName = value; } }
    private bool SlotOccupied = false;
    public bool HasPlayer
    {
        get
        {
            if (IsDirectPlayer)
            {
                return true;
            }
            else
            {
                return SlotOccupied;
            }
        }
        set
        {
            SlotOccupied = value;
        }
    }

    // Functions
    public void OnClick()
    {
        if (HasPlayer)
        {
            // Load Profile
            MainMenuManager.OpenSocialPageOnPlayerProfile();
        }
        else
        {
            // Go to invite player 
            MainMenuManager.OpenSocialPageOnInvite();
        }
    }
}
