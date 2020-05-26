using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class SmartButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    // Parameters
    [SerializeField]
    private float SizeIncreaseOnHover = 1;
    [SerializeField]
    private float SizeIncreaseTime = 1;
    [SerializeField]
    private float SizeDecreaseTime = 1;
    [SerializeField]
    private LeanTweenType SizeChangeTweenType = LeanTweenType.linear;
    [SerializeField]
    private Color TextColorOnHoverEnter = Color.white;
    [SerializeField]
    private Color TextColorOnHoverExit = Color.black;
    [SerializeField]
    private Color ImageColorOnHoverEnter = Color.white;
    [SerializeField]
    private Color ImageColorOnHoverExit = Color.black;
    [SerializeField]
    private Color ImageColorOnClick = Color.black;


    // Objects
    [SerializeField]
    private TMPro.TextMeshProUGUI ButtonText;
    [SerializeField]
    private Image ButtonImage;
    [SerializeField]
    public SmartButton LeftButton;
    [SerializeField]
    private SmartButton RightButton;
    [SerializeField]
    private SmartButton UpButton;
    [SerializeField]
    private SmartButton DownButton;
    [SerializeField]
    private SmartButtonManager ButtonManager = null;

    // Variables
    public SmartButton Left { get { return LeftButton; } }
    public SmartButton Right { get { return RightButton; } }
    public SmartButton Up { get { return UpButton; } }
    public SmartButton Down { get { return DownButton; } }

    // Events
    public UnityEvent OnClick;

    // Functions
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (ButtonManager != null)
        {
            ButtonManager.CurrentSmartButton = this;
            ButtonManager.SetToButton(this);
        }
        else
        {
            HoverOverButton();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (ButtonManager == null)
            HoverExitButton();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        InvokeButton();
    }

    public void HoverOverButton()
    {
        ButtonImage.color = ImageColorOnHoverEnter;
        ButtonText.color = TextColorOnHoverEnter;
        LeanTween.scaleY(gameObject, SizeIncreaseOnHover, SizeIncreaseTime);
    }

    public void HoverExitButton()
    {
        ButtonImage.color = ImageColorOnHoverExit;
        ButtonText.color = TextColorOnHoverExit;
        LeanTween.scaleY(gameObject, 1, SizeDecreaseTime);
    }

    public void InvokeButton()
    {
        if (OnClick != null)
        {
            OnClick.Invoke();
        }
    }
}
