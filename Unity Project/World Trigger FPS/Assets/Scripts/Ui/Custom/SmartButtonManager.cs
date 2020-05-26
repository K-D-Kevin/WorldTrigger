using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartButtonManager : MonoBehaviour
{
    // Objects
    [SerializeField]
    private SmartButton DefaultButton;
    [SerializeField]
    private List<SmartButton> ManagingButtons = new List<SmartButton>();

    // Variables
    public SmartButton CurrentSmartButton { get; set; }
    public SmartButton DefaultSmartButton { get { return DefaultButton; } }

    // Functions
    public void ReturnToDefault()
    {
        SetToButton(DefaultButton);
    }

    public void SetToButton(SmartButton SetToButton)
    {
        if (ManagingButtons.Contains(SetToButton))
        {
            foreach (SmartButton button in ManagingButtons)
            {
                if (button != SetToButton)
                    button.HoverExitButton();
            }
            SetToButton.HoverOverButton();
        }
    }
}
