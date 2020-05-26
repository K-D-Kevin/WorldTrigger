using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartySlot : MonoBehaviour
{
    // Parameters

    // Objects
    [SerializeField]
    private Image IconImage;

    // Variables
    public Image Icon { get { return IconImage; } }
    private Sprite SpriteImage;
    public Sprite IconSprite { get { return SpriteImage; } set { SpriteImage = value; Icon.sprite = SpriteImage; } }
    public string DisplayName = "";
    public string PlayersName { get { return DisplayName; } set { DisplayName = value; } }

    // Functions
    public void AddPlayerToSlot()
    {

    }
}
